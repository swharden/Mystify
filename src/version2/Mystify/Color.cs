using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MystifySharp.Mystify
{
    public class Color
    {
        public byte A, R, G, B;
        public Int32 ARGB { get { return BitConverter.ToInt32(new byte[] { R, G, B, A }, 0); } }

        public Color(int R, int G, int B)
        {
            this.A = 255;
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

        public Color(Color source)
        {
            A = source.A;
            R = source.R;
            G = source.G;
            B = source.B;
        }
    }
}
