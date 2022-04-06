using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MystifySharp.Model;
using SkiaSharp.Views.Desktop;

namespace MystifySharp
{
    public partial class AdvancedForm : Form
    {
        Field Field = new(10, 10);

        public AdvancedForm()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 600;
            skglControl1.PaintSurface += SkglControl1_PaintSurface;
            ResetField();
        }

        private void nudPolygonCount_ValueChanged(object sender, EventArgs e) => ResetField();
        private void nudCornerCount_ValueChanged(object sender, EventArgs e) => ResetField();
        private void nudHistory_ValueChanged(object sender, EventArgs e) => UpdateField();
        private void nudSpeed_ValueChanged(object sender, EventArgs e) => UpdateField();
        private void nudColorStep_ValueChanged(object sender, EventArgs e) => UpdateField();
        private void cbAntiAlias_CheckedChanged(object sender, EventArgs e) => UpdateField();
        private void cbFade_CheckedChanged(object sender, EventArgs e) => UpdateField();

        private void SkglControl1_PaintSurface(object? sender, SKPaintGLSurfaceEventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new();
            sw.Start();
            Field.Draw(e.Surface.Canvas);
            sw.Stop();
            lblStatus.Text = $"{e.Info.Size.Width}x{e.Info.Size.Height} " +
                $"rendered in {sw.Elapsed.TotalMilliseconds:N3} ms " +
                $"({1.0 / sw.Elapsed.TotalSeconds:N3} fps)";
        }

        private void ResetField()
        {
            Field = new Field(
                width: skglControl1.Width,
                height: skglControl1.Height,
                wireCount: (int)nudPolygonCount.Value,
                cornerCount: (int)nudCornerCount.Value);

            UpdateField();
        }

        private void UpdateField()
        {
            Field.History = (int)nudHistory.Value;
            Field.Speed = (float)nudSpeed.Value / 100;
            Field.ColorChangeSpeed = (int)nudColorStep.Value / 100;
            Field.AntiAlias = cbAntiAlias.Checked;
            Field.Fade = cbFade.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Field.Resize(skglControl1.Width, skglControl1.Height);
            Field.Advance();
            skglControl1.Invalidate();
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            using AdvancedFormFullScreen fs = new(Field);
            fs.ShowDialog();
            timer1.Start();
        }
    }
}
