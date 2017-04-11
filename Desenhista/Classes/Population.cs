using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Desenhista.Classes
{
    public class Population
    {
        private List<Draftsman> organism;
        public int generation;
        public int countDNA;
        

        public Population()
        {
            organism = new List<Draftsman>();
        }

        public List<Draftsman> GetPopulation()
        {
            return organism;
        }

        public void GenerateStartPopulation()
        {
            generation = 0;
            countDNA = 0;
            for (int i = 0; i < Tools.population; i++)
            {
                Draftsman d = new Draftsman();
                d.GenerateDNA();
                organism.Add(d);
            }
        }

        /// <summary>
        /// Avaliar
        /// </summary>
        /// <returns></returns>
        public void ToEvaluate()
        {
            double fitness = 0;

            foreach (var o in organism)
            {
                switch (Tools.typeAvaliation)
                {
                    case Tools.TypeAvaliation.originalImage:
                        var ri1 = Tools.GetBytesFromBitmap(o.GetImage());
                        var ri2 = Tools.GetBytesFromBitmap(Tools.imageTarget);
                        fitness = Tools.CalculateFitnessWithLinq(ri1, ri2);
                        break;
                    
                    case Tools.TypeAvaliation.reducedImage:
                        var rim1 = Tools.GetBytesFromBitmap(o.GetImagemReduced());
                        var rim2 = Tools.GetBytesFromBitmap(Tools.imageTargetReduced);
                        fitness = Tools.CalculateFitnessWithLinq(rim1, rim2);
                        break;

                    case Tools.TypeAvaliation.byPixelOriginalImage:
                        fitness = Tools.CalculateFitnessWithPixel(o.GetImage(), Tools.imageTarget);
                        break;
                
                    case Tools.TypeAvaliation.byPixelReducedImage:
                        fitness = Tools.CalculateFitnessWithPixel(o.GetImagemReduced(), Tools.imageTargetReduced);
                        break;
                }
                o.fitness = (int)fitness;
            }
            organism = organism.OrderBy(o => o.fitness).ToList();
        }

        /// <summary>
        /// SelecaoNatural
        /// </summary>
        public void NaturalSelection()
        {
            switch (Tools.typeNaturalSelection)
            {
                case Tools.TypeNaturalSelection.elitist:
                    organism.RemoveRange(1, organism.Count - 1);
                    break;
                case Tools.TypeNaturalSelection.half:
                    int metade = Tools.population / 2;
                    organism.RemoveRange(metade, metade);
                    break;

            }
        }

        /// <summary>
        /// CrossOver
        /// </summary>
        public void CrossOver()
        {
            Draftsman father = organism[0];

            switch (Tools.typeNaturalSelection)
            {
                case Tools.TypeNaturalSelection.elitist:
                    for (int i = organism.Count; i < Tools.population; i++)
                        organism.Add(Tools.Clone<Draftsman>(father));
                    break;
                case Tools.TypeNaturalSelection.half:
                    bool tictac = true;
                    Draftsman mother = organism[1];
                    for (int i = organism.Count; i < Tools.population; i++)
                    {
                        if (father.DNA.Count < 6)
                        {
                            if (tictac)
                            {
                                Draftsman son1 = new Draftsman();
                                son1.DNA = father.DNA;
                                son1.Draw();
                                organism.Add(son1);
                            }
                            else
                            {
                                Draftsman son2 = new Draftsman();
                                son2.DNA = mother.DNA;
                                son2.Draw();
                                organism.Add(son2);
                            }
                        }
                        else
                        {
                            int slice1 = Rnd.GetRandomNumber(1, father.DNA.Count / 2);
                            int slice2 = Rnd.GetRandomNumber(father.DNA.Count / 2, father.DNA.Count);
                            if (tictac)
                            {
                                Draftsman son1 = new Draftsman();
                                son1.DNA.AddRange(father.DNA.GetRange(0, slice1));
                                son1.DNA.AddRange(mother.DNA.GetRange(slice1, slice2 - slice1));
                                son1.DNA.AddRange(father.DNA.GetRange(slice2, mother.DNA.Count - slice2));
                                son1.Draw();
                                organism.Add(son1);
                            }
                            else
                            {
                                Draftsman son2 = new Draftsman();
                                son2.DNA.AddRange(mother.DNA.GetRange(0, slice1));
                                son2.DNA.AddRange(father.DNA.GetRange(slice1, slice2 - slice1));
                                son2.DNA.AddRange(mother.DNA.GetRange(slice2, mother.DNA.Count - slice2));
                                son2.Draw();
                                organism.Add(son2);
                            }
                        }
                        tictac = !tictac;
                    }
                    break;
            }
        }

        /// <summary>
        /// Mutar
        /// </summary>
        public void Mutation()
        {
            int coefficientX = Tools.maxWidth * Tools.mutation / 100;
            int coefficientY = Tools.maxHeight * Tools.mutation / 100;
            int coefficientDiameter = Tools.maxDiameter * Tools.mutation / 100;
            int coefficientColor = 255 * Tools.mutation / 100;

            foreach (var item in organism.Skip(1)) //só não muta o pai
            {
                List<Tuple<Rectangle, Color>> DNA = new List<Tuple<Rectangle, Color>>();

                foreach (var dna in item.DNA)
                {
                    Rectangle rectangle = new Rectangle();
                    Color color = new Color();

                    rectangle = dna.Item1;
                    color = dna.Item2;

                    int r = color.R, g = color.G, b = color.B, a = color.A;

                    if (Rnd.GetRandomNumber(0, 10) < 5)
                    {
                        rectangle.X += Rnd.GetRandomNumber(coefficientX * -1, coefficientX);
                        rectangle.Y += Rnd.GetRandomNumber(coefficientY * -1, coefficientY);
                        
                        int diameter = Rnd.GetRandomNumber(coefficientDiameter * -1, coefficientDiameter);
                        rectangle.Width += diameter;
                        rectangle.Height += diameter;

                        //rectangle.Width += Rnd.GetRandomNumber(coefficientDiameter * -1, coefficientDiameter);
                        //rectangle.Height += Rnd.GetRandomNumber(coefficientDiameter * -1, coefficientDiameter);

                        r += Rnd.GetRandomNumber(coefficientColor * -1, coefficientColor);
                        if (r > 255) r = 255;
                        if (r < 0) r = 0;

                        g += Rnd.GetRandomNumber(coefficientColor * -1, coefficientColor);
                        if (g > 255) g = 255;
                        if (g < 0) g = 0;

                        b += Rnd.GetRandomNumber(coefficientColor * -1, coefficientColor);
                        if (b > 255) b = 255;
                        if (b < 0) b = 0;

                        a += Rnd.GetRandomNumber(coefficientColor * -1, coefficientColor);
                        if (a > 255) a = 255;
                        if (a < 0) a = 0;
                    }

                    DNA.Add(new Tuple<Rectangle, Color>(rectangle, Color.FromArgb(a, r, g, b)));
                }

                item.SetDNA(DNA);
            }
        }

        public void NextGeneration()
        {
            if (generation < Tools.generation)
                generation++;
            else
                return;

            if (generation % 10 == 0 && Tools.countDNA < Tools.maxDNA)
            {
                Tools.countDNA += Tools.addDNA;
                foreach (var item in GetPopulation())
                {
                    item.GenerateDNA();
                }
            }

        }
    }
}
