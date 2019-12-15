using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MystifySharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmp;
        Mystify.Field field;
        Stopwatch stopwatch = new Stopwatch();
        int renderCount;
        private void ResetField()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            //field = new Field(bmp.Width, bmp.Height, (int)ShapeCountNUD.Value, ComplexityTrackbar.Value, LineWidthTrackbar.Value);
            field = new Mystify.Field(bmp.Width, bmp.Height, polygonCount: (int)ShapeCountNUD.Value, cornerCount: ComplexityTrackbar.Value);
            stopwatch.Restart();
            renderCount = 0;
        }

        private void Render()
        {
            if ((bmp == null) || (pictureBox1.Size != bmp.Size))
                ResetField();

            foreach (Mystify.MovingPolygon movingPolygon in field.polygons)
                movingPolygon.StepForward(SpeedTrackbar.Value, lineWidth: LineWidthTrackbar.Value);

            RenderEngineGDI.Render(bmp, field, AntiAliasCheckbox.Checked);
            pictureBox1.Image = bmp;

            double frameRateHz = (double)renderCount / (stopwatch.ElapsedMilliseconds / 1000.0);
            Text = string.Format("{0:0.00} FPS", frameRateHz);
            renderCount += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Render();
        }

        private void ComplexityTrackbar_Scroll(object sender, EventArgs e)
        {
            ResetField();
        }

        private void ShapeCountNUD_ValueChanged(object sender, EventArgs e)
        {
            ResetField();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetField();
        }

        private void LineWidthTrackbar_Scroll(object sender, EventArgs e)
        {
            ResetField();
        }

        private void AntiAliasCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ResetField();
        }

        private void GitHubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/swharden/Mystify");
        }
    }
}
