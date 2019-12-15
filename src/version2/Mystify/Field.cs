using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MystifySharp.Mystify
{
    public class Field
    {
        Random rand = new Random();
        public readonly List<MovingPolygon> polygons = new List<MovingPolygon>();

        public Field(int width, int height, int polygonCount = 10, int cornerCount = 5)
        {
            for (int i=0; i<polygonCount; i++)
            {
                Color randomColor = new Color(rand.Next(256), rand.Next(256), rand.Next(256));
                polygons.Add(new MovingPolygon(width, height, cornerCount, randomColor, rand));
            }
        }
    }
}
