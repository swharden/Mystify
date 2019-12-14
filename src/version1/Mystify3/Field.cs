using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp39.Mystify3
{
    public class Field
    {
        public Shape[] shapes;
        Random rand = new Random();

        public Field(int width, int height, int shapeCount, int cornersPerShape, int tailSize)
        {
            shapes = new Shape[shapeCount];
            for (int i = 0; i < shapes.Length; i++)
                shapes[i] = new Shape(width, height, cornersPerShape, tailSize, rand);
        }

        public void StepForward(double stepSize = 1.0)
        {
            for (int i = 0; i < shapes.Length; i++)
                shapes[i].StepForward(stepSize);
        }
    }
}
