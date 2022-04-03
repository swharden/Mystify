using SkiaSharp;

namespace MystifySharp
{
    public partial class Form1 : Form
    {
        readonly Model.Field ParticleField = new();

        public Form1()
        {
            InitializeComponent();
            skglControl1.PaintSurface += SkglControl1_PaintSurface;
            ParticleField.Reset(100, skglControl1.Width, skglControl1.Height);
        }

        private void SkglControl1_PaintSurface(object? sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            ParticleField.Draw(e.Surface.Canvas);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ParticleField.Advance(2, skglControl1.Size.Width, skglControl1.Size.Height);
            skglControl1.Invalidate();
        }
    }
}