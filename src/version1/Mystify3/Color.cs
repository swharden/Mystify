using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp39.Mystify3
{
    public class Color
    {
        public byte A, R, G, B;
        public Int32 ARGB { get { return BitConverter.ToInt32(new byte[] { A, R, G, B }, 0); } }

        public Color(int R, int G, int B)
        {
            A = 255;
            this.R = (byte)R;
            this.G = (byte)G;
            this.B = (byte)B;
        }

        public Color(int A, int R, int G, int B)
        {
            this.A = (byte)A;
            this.R = (byte)R;
            this.G = (byte)G;
            this.B = (byte)B;
        }

        private void RandomizeColor(Random rand)
        {
            A = 255;
            R = (byte)rand.Next(256);
            G = (byte)rand.Next(256);
            B = (byte)rand.Next(256);
        }

        public Color(Random rand, bool mustBeBright = true)
        {
            RandomizeColor(rand);
            if (mustBeBright)
                while (R + G + B < 400)
                    RandomizeColor(rand);
        }
    }
}
