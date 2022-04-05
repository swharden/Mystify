using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MystifySharp
{
    public partial class Form3 : Form
    {
        readonly Model.Field Field;

        public Form3()
        {
            InitializeComponent();
            Field = new(skglControl1.Width, skglControl1.Height);
            skglControl1.PaintSurface += SkglControl1_PaintSurface;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Field.Resize(skglControl1.Width, skglControl1.Height);
            Field.Advance();
            skglControl1.Invalidate();
        }

        private void SkglControl1_PaintSurface(object? sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            Field.Draw(e.Surface.Canvas);
        }
    }
}
