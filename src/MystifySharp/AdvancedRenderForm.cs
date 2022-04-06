﻿using System;
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
    public partial class AdvancedRenderForm : Form
    {
        readonly Model.Field Field;
        SKVideoMaker? Maker = null;

        public AdvancedRenderForm(Model.Field field)
        {
            InitializeComponent();
            Field = field;
        }

        private void btnRender_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "starting renderer...";
            Application.DoEvents();
            IFrameGenerator generator = new Model.FieldFrameGenerator(Field);
            Maker = new(generator, (int)(nudFps.Value * nudSeconds.Value), (int)nudFps.Value);
            _ = Maker.RenderAsync_X264("mystify.mp4");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Maker is not null)
                Maker.Cancel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Maker is null)
                return;

            lblStatus.Text = Maker.Status;
            progressBar1.Maximum = Maker.FrameCount;
            progressBar1.Value = Maker.CurrentFrame;
        }
    }
}
