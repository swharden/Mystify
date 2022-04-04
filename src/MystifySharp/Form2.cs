using FFMpegCore;
using FFMpegCore.Pipes;
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
    public partial class Form2 : Form
    {
        readonly SKVideoMaker VideoMaker;

        public Form2()
        {
            InitializeComponent();
            UpdateDurationLabel();
            label3.Text = "Render job not started";

            VideoMaker = new SKVideoMaker(640, 460);
            VideoMaker.RenderingComplete += OnRenderingComplete;
            VideoMaker.RenderingNewFrame += OnRenderingNewFrame;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = $"Rendering: Cancelling...";
            VideoMaker.Cancel();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) => UpdateDurationLabel();

        private void UpdateDurationLabel()
        {
            int fps = 30;
            TimeSpan duration = TimeSpan.FromSeconds((int)numericUpDown1.Value / fps);
            label2.Text = $"{duration.Minutes} min {duration.Seconds} sec";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Starting rendering system...";
            _ = VideoMaker.RenderAsync((int)numericUpDown1.Value);
        }

        private void OnRenderingComplete(object? sender, EventArgs args)
        {
            progressBar1.Invoke(() =>
            {
                progressBar1.Value = 0;
                progressBar1.Enabled = false;
            });

            label3.Invoke(() =>
            {
                label3.Text = $"Rendering: Complete";
            });
        }

        private void OnRenderingNewFrame(object? sender, EventArgs args)
        {
            progressBar1.Invoke(() =>
            {
                progressBar1.Maximum = VideoMaker.TotalFrames;
                progressBar1.Value = VideoMaker.CurrentFrame;
                progressBar1.Enabled = true;
            });

            label3.Invoke(() =>
            {
                label3.Text = $"Rendering: Frame {VideoMaker.CurrentFrame} of {VideoMaker.TotalFrames}...";
            });
        }
    }
}
