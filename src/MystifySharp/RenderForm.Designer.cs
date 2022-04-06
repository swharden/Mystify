namespace MystifySharp
{
    partial class RenderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudFps = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRender = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbWebM = new System.Windows.Forms.RadioButton();
            this.rbX264 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFps)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(12, 27);
            this.nudWidth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(68, 23);
            this.nudWidth.TabIndex = 0;
            this.nudWidth.Value = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(86, 27);
            this.nudHeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(68, 23);
            this.nudHeight.TabIndex = 1;
            this.nudHeight.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(234, 27);
            this.nudSeconds.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(68, 23);
            this.nudSeconds.TabIndex = 2;
            this.nudSeconds.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // nudFps
            // 
            this.nudFps.Location = new System.Drawing.Point(160, 27);
            this.nudFps.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudFps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFps.Name = "nudFps";
            this.nudFps.Size = new System.Drawing.Size(68, 23);
            this.nudFps.TabIndex = 3;
            this.nudFps.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "FPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seconds";
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(390, 9);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(75, 41);
            this.btnRender.TabIndex = 8;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(471, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 41);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(534, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 91);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbWebM
            // 
            this.rbWebM.AutoSize = true;
            this.rbWebM.Location = new System.Drawing.Point(308, 31);
            this.rbWebM.Name = "rbWebM";
            this.rbWebM.Size = new System.Drawing.Size(60, 19);
            this.rbWebM.TabIndex = 12;
            this.rbWebM.Text = "WebM";
            this.rbWebM.UseVisualStyleBackColor = true;
            // 
            // rbX264
            // 
            this.rbX264.AutoSize = true;
            this.rbX264.Checked = true;
            this.rbX264.Location = new System.Drawing.Point(308, 7);
            this.rbX264.Name = "rbX264";
            this.rbX264.Size = new System.Drawing.Size(76, 19);
            this.rbX264.TabIndex = 13;
            this.rbX264.TabStop = true;
            this.rbX264.Text = "x264 MP4";
            this.rbX264.UseVisualStyleBackColor = true;
            // 
            // RenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 113);
            this.Controls.Add(this.rbX264);
            this.Controls.Add(this.rbWebM);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSeconds);
            this.Controls.Add(this.nudFps);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.Name = "RenderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvancedRenderForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFps)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudWidth;
        private NumericUpDown nudHeight;
        private NumericUpDown nudSeconds;
        private NumericUpDown nudFps;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRender;
        private Button btnStop;
        private ProgressBar progressBar1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Timer timer1;
        private RadioButton rbWebM;
        private RadioButton rbX264;
    }
}