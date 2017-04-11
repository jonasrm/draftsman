using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Desenhista.Classes
{
    public static class Tools
    {
        public enum TypeAvaliation
        {
            originalImage,
            reducedImage,
            byPixelOriginalImage,
            byPixelReducedImage
        }

        public enum TypeNaturalSelection
        {
            elitist,
            half
        }

        public enum TypeForm
        {
            ellipse,
            square,
            dot
        }

        public static int population { get; set; }
        public static int mutation { get; set; }
        public static int generation { get; set; }
        public static int maxWidth { get; set; }
        public static int maxHeight { get; set; }
        public static int maxDiameter { get; set; }
        public static int maxDNA { get; set; }
        public static int countDNA { get; set; }
        public static int addDNA { get; set; }
        public static Bitmap imageTarget { get; set; }
        public static Bitmap imageTargetReduced { get; set; }
        public static Bitmap imageTargetThreshold { get; set; }
        public static List<bool> imageTargetHash { get; set; }
        public static TypeAvaliation typeAvaliation { get; set; }
        public static TypeNaturalSelection typeNaturalSelection { get; set; }
        public static TypeForm typeForm { get; set; }

        public static T Clone<T>(T source)
        {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }

        public static List<bool> GetHash(Bitmap bmpSource, float threshold = 0.5f)
        {
            List<bool> result = new List<bool>();
            
            for (int x = 0; x < bmpSource.Width; x++)
                for (int y = 0; y < bmpSource.Height; y++)
                    result.Add(bmpSource.GetPixel(x, y).GetBrightness() < threshold);

            return result;
        }

        public static Bitmap GetResize(Bitmap bmpSource, int width, int height)
        {
            Bitmap bmpMin = new Bitmap(bmpSource, new Size(width, height));
            return bmpMin;
        }

        public static Bitmap GetThreshold(Bitmap bmpSource, int width, int height, float threshold = 0.5f)
        {
            Bitmap bmpMin = new Bitmap(bmpSource, new Size(width, height));
            Bitmap bmpTS = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    if (bmpMin.GetPixel(x, y).GetBrightness() < threshold)
                        bmpTS.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    else
                        bmpTS.SetPixel(x, y, Color.FromArgb(255, 255, 255));

            return bmpTS;
        }

        public static byte[] GetBytesFromBitmap(this Bitmap bitmap)
        {
            var rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            var bData = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, bitmap.PixelFormat);
            byte[] data;
            try
            {
                int size = bData.Stride * bData.Height;
                data = new byte[size];
                Marshal.Copy(bData.Scan0, data, 0, size);
            }
            finally
            {
                bitmap.UnlockBits(bData);
            }
            return data;
        }

        public static double CalculateFitnessWithLinq(byte[] tempBytes, byte[] bitmapBytes)
        {
            double fitness = Enumerable.Range(0, tempBytes.Length).Sum(i => Math.Abs(tempBytes[i] - bitmapBytes[i]));
            return fitness;
        }

        public static double CalculateFitnessWithPixel(Bitmap image1, Bitmap image2)
        {
            double fitness = 0;
            
            if (image1.Width != image2.Width || image1.Height != image2.Height)
                return fitness;

            
            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    Color color1 = image1.GetPixel(x, y);
                    Color color2 = image2.GetPixel(x, y);
                    double deltaE = Math.Sqrt(Math.Pow((color1.R - color2.R), 2) + Math.Pow((color1.G - color2.G), 2) + Math.Pow((color1.B - color2.B), 2));
                    fitness += deltaE;
                }
            }

            return fitness;
        }

    }
}
