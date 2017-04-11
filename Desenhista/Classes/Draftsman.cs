using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenhista.Classes
{
    public class Draftsman
    {
        public List<Tuple<Rectangle, Color>> DNA;
        public double fitness;
        private Bitmap imageOriginal;
        private Bitmap imageReduced;

        public Draftsman()
        {
            DNA = new List<Tuple<Rectangle, Color>>();
            imageOriginal = new Bitmap(Tools.maxWidth, Tools.maxHeight);
            fitness = 100;
        }

        /// <summary>
        /// GenerateDNA
        /// </summary>
        public void GenerateDNA()
        {
            for (int i = DNA.Count; i < Tools.countDNA; i++)
            {
                int diameter = Rnd.GetRandomNumber(1, Tools.maxDiameter);
                Rectangle rectangle = new Rectangle()
                {
                    X = Rnd.GetRandomNumber(0, Tools.maxWidth) - diameter / 2,
                    Y = Rnd.GetRandomNumber(0, Tools.maxHeight) - diameter / 2,
                    Height = diameter,
                    Width = diameter
                };
                DNA.Add(new Tuple<Rectangle, Color>(rectangle, Color.FromArgb(Rnd.GetRandomNumber(0, 255), Rnd.GetRandomNumber(0, 255), Rnd.GetRandomNumber(0, 255), Rnd.GetRandomNumber(0, 255))));
            }
            this.Draw();
        }

        /// <summary>
        /// SetDNA
        /// </summary>
        /// <param name="DNA"></param>
        public void SetDNA(List<Tuple<Rectangle, Color>> DNA)
        {
            this.DNA = new List<Tuple<Rectangle, Color>>(DNA);
            this.Draw();
        }

        /// <summary>
        /// Draw
        /// </summary>
        public void Draw()
        {
            Brush b;
            Graphics gra = Graphics.FromImage(imageOriginal);

            //fundo branco
            b = new SolidBrush(Color.White);
            gra.FillRectangle(b, 0,0,imageOriginal.Width, imageOriginal.Height);

            foreach (var d in DNA)
            {
                b = new SolidBrush(d.Item2);

                switch (Tools.typeForm)
                {
                    case Tools.TypeForm.ellipse:
                        gra.FillEllipse(b, d.Item1);
                        break;
                    case Tools.TypeForm.square:
                        gra.FillRectangle(b, d.Item1);
                        break;
                    case Tools.TypeForm.dot:
                        var dot = d.Item1;
                        gra.FillRectangle(b, dot);
                        break;
                }
            }
            imageReduced = Tools.GetResize(imageOriginal, 16, 16);
        }

        /// <summary>
        /// GetImage
        /// </summary>
        /// <returns></returns>
        public Bitmap GetImage()
        {
            return imageOriginal;
        }

        /// <summary>
        /// GetImagemReduced
        /// </summary>
        /// <returns></returns>
        public Bitmap GetImagemReduced()
        {
            return imageReduced;
        }

    }
}
