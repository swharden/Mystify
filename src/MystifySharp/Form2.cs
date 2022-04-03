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

            VideoMaker = new SKVideoMaker(640, 460);
            VideoMaker.RenderingComplete += OnRenderingComplete;
            VideoMaker.RenderingNewFrame += OnRenderingNewFrame;
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
            UpdateProgress(0, 0, "Starting rendering system...");
            _ = VideoMaker.RenderAsync((int)numericUpDown1.Value);
        }

        static void SynchronizedInvoke(ISynchronizeInvoke sync, Action action)
        {
            if (sync.InvokeRequired)
                _ = sync.Invoke(action, Array.Empty<object>());
            else
                action();
        }

        public void UpdateProgress(int frame, int frameMax, string message)
        {
            SynchronizedInvoke(progressBar1, delegate ()
            {
                progressBar1.Maximum = frameMax;
                progressBar1.Value = frame;
                progressBar1.Enabled = frameMax > 0;
            });

            SynchronizedInvoke(label3, delegate ()
            {
                label3.Text = message;
            });
        }

        private void OnRenderingComplete(object? sender, EventArgs args)
        {
            UpdateProgress(0, 0, "Rendering: Complete.");
        }

        private void OnRenderingNewFrame(object? sender, EventArgs args)
        {
            string message = $"Rendering: Frame {VideoMaker.CurrentFrame} of {VideoMaker.TotalFrames}...";
            UpdateProgress(VideoMaker.CurrentFrame, VideoMaker.TotalFrames, message);
        }
    }
}
