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
    public partial class RenderForm : Form
    {
        SKVideoMaker? VideoMaker;

        public RenderForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = VideoMaker?.Status;
            progressBar1.Maximum = VideoMaker?.FrameCount ?? 1;
            progressBar1.Value = VideoMaker?.CurrentFrame ?? 0;
            skglControl1.Invalidate();
        }

        private void skglControl1_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            if (VideoMaker is not null)
                e.Surface.Canvas.DrawBitmap(VideoMaker.Model.Bitmap, 0, 0);
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "preparing to render";
            Application.DoEvents();
            IFrameGenerator gen = new Model.FieldFrameGenerator((int)nudWidth.Value, (int)nudHeight.Value);
            int fps = (int)nudFps.Value;
            int frameCount = fps * (int)nudLengthSec.Value;
            VideoMaker = new SKVideoMaker(gen, frameCount, fps);
            VideoMaker?.RenderAsync_X264(tbFilename.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            VideoMaker?.Cancel();
        }
    }
}
