using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp39.Mystify3
{
    public class Shape
    {
        public readonly Corner[] corners;
        private readonly double Width, Height;
        private readonly int TailSize;
        Random rand;
        public Color color;

        public Shape(int width, int height, int cornersPerShape, int tailSize, Random rand)
        {
            Width = width;
            Height = height;
            TailSize = tailSize;

            corners = new Corner[cornersPerShape];
            for (int i = 0; i < corners.Length; i++)
                corners[i] = new Corner();

            this.rand = rand;
            Randomize();
        }

        public void Randomize()
        {
            for (int i = 0; i < corners.Length; i++)
            {
                corners[i].X = rand.NextDouble() * Width;
                corners[i].Y = rand.NextDouble() * Height;
                corners[i].velX = rand.NextDouble() * 2 - 1;
                corners[i].velY = rand.NextDouble() * 2 - 1;
            }
            color = new Color(rand);
        }

        public void StepForward(double stepSize = 1.0)
        {
            for (int i = 0; i < corners.Length; i++)
            {
                corners[i].StepForward(stepSize);

                // reflect off edges
                if (corners[i].X < 0 || corners[i].X > Width)
                    corners[i].velX *= -1;
                if (corners[i].Y < 0 || corners[i].Y > Height)
                    corners[i].velY *= -1;

                // delete old tails
                while (corners[i].Xs.Count() > TailSize)
                    corners[i].Xs.RemoveAt(0);
                while (corners[i].Ys.Count() > TailSize)
                    corners[i].Ys.RemoveAt(0);
            }
        }
    }
}
