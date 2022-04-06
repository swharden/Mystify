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
    public partial class FullScreenForm : Form
    {
        readonly Model.Field Field;

        public FullScreenForm(Model.Field field)
        {
            InitializeComponent();
            Field = field;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            KeyDown += OnKeyDown;
            skglControl1.KeyDown += OnKeyDown;
        }

        private void AdvancedFormFullScreen_Load(object sender, EventArgs e)
        {
            Field.Resize(skglControl1.Width, skglControl1.Height, reset: true);
        }

        private void OnKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Field.Resize(skglControl1.Width, skglControl1.Height);
            Field.Advance();
            skglControl1.Invalidate();
        }

        private void skglControl1_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            Field.Draw(e.Surface.Canvas);
        }
    }
}
