using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp39.Mystify3
{
    public class Corner
    {
        public double X, Y, velX, velY;
        public List<double> Xs = new List<double>();
        public List<double> Ys = new List<double>();

        public void StepForward(double stepSize = 1.0)
        {
            Xs.Add(X);
            Ys.Add(Y);

            X += velX * stepSize;
            Y += velY * stepSize;
        }
    }
}