namespace MystifySharp
{
    partial class AdvancedForm
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
            this.nudPolygonCount = new System.Windows.Forms.NumericUpDown();
            this.nudCornerCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudColorStep = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAntiAlias = new System.Windows.Forms.CheckBox();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHistory = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.skglControl1 = new SkiaSharp.Views.Desktop.SKGLControl();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbFade = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPolygonCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCornerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistory)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudPolygonCount
            // 
            this.nudPolygonCount.Location = new System.Drawing.Point(12, 27);
            this.nudPolygonCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPolygonCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPolygonCount.Name = "nudPolygonCount";
            this.nudPolygonCount.Size = new System.Drawing.Size(67, 23);
            this.nudPolygonCount.TabIndex = 4;
            this.nudPolygonCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPolygonCount.ValueChanged += new System.EventHandler(this.nudPolygonCount_ValueChanged);
            // 
            // nudCornerCount
            // 
            this.nudCornerCount.Location = new System.Drawing.Point(85, 27);
            this.nudCornerCount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudCornerCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCornerCount.Name = "nudCornerCount";
            this.nudCornerCount.Size = new System.Drawing.Size(67, 23);
            this.nudCornerCount.TabIndex = 5;
            this.nudCornerCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCornerCount.ValueChanged += new System.EventHandler(this.nudCornerCount_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Corners";
            // 
            // nudColorStep
            // 
            this.nudColorStep.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudColorStep.Location = new System.Drawing.Point(304, 27);
            this.nudColorStep.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudColorStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColorStep.Name = "nudColorStep";
            this.nudColorStep.Size = new System.Drawing.Size(67, 23);
            this.nudColorStep.TabIndex = 9;
            this.nudColorStep.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudColorStep.ValueChanged += new System.EventHandler(this.nudColorStep_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Polygons";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color step";
            // 
            // cbAntiAlias
            // 
            this.cbAntiAlias.AutoSize = true;
            this.cbAntiAlias.Checked = true;
            this.cbAntiAlias.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAntiAlias.Location = new System.Drawing.Point(377, 28);
            this.cbAntiAlias.Name = "cbAntiAlias";
            this.cbAntiAlias.Size = new System.Drawing.Size(68, 19);
            this.cbAntiAlias.TabIndex = 13;
            this.cbAntiAlias.Text = "Smooth";
            this.cbAntiAlias.UseVisualStyleBackColor = true;
            this.cbAntiAlias.CheckedChanged += new System.EventHandler(this.cbAntiAlias_CheckedChanged);
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(231, 27);
            this.nudSpeed.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(67, 23);
            this.nudSpeed.TabIndex = 14;
            this.nudSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Speed";
            // 
            // nudHistory
            // 
            this.nudHistory.Location = new System.Drawing.Point(158, 27);
            this.nudHistory.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudHistory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHistory.Name = "nudHistory";
            this.nudHistory.Size = new System.Drawing.Size(67, 23);
            this.nudHistory.TabIndex = 16;
            this.nudHistory.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHistory.ValueChanged += new System.EventHandler(this.nudHistory_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "History";
            // 
            // skglControl1
            // 
            this.skglControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skglControl1.BackColor = System.Drawing.Color.Black;
            this.skglControl1.Location = new System.Drawing.Point(12, 56);
            this.skglControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skglControl1.Name = "skglControl1";
            this.skglControl1.Size = new System.Drawing.Size(866, 456);
            this.skglControl1.TabIndex = 18;
            this.skglControl1.VSync = true;
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullScreen.Location = new System.Drawing.Point(804, 12);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(75, 36);
            this.btnFullScreen.TabIndex = 19;
            this.btnFullScreen.Text = "Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbFade
            // 
            this.cbFade.AutoSize = true;
            this.cbFade.Location = new System.Drawing.Point(451, 28);
            this.cbFade.Name = "cbFade";
            this.cbFade.Size = new System.Drawing.Size(51, 19);
            this.cbFade.TabIndex = 20;
            this.cbFade.Text = "Fade";
            this.cbFade.UseVisualStyleBackColor = true;
            this.cbFade.CheckedChanged += new System.EventHandler(this.cbFade_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 17);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // btnVideo
            // 
            this.btnVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVideo.Location = new System.Drawing.Point(723, 12);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(75, 36);
            this.btnVideo.TabIndex = 22;
            this.btnVideo.Text = "Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // AdvancedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 547);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.skglControl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVideo);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.cbFade);
            this.Controls.Add(this.cbAntiAlias);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.nudHistory);
            this.Controls.Add(this.nudPolygonCount);
            this.Controls.Add(this.nudCornerCount);
            this.Controls.Add(this.nudColorStep);
            this.Name = "AdvancedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mystify Sandbox";
            ((System.ComponentModel.ISupportInitialize)(this.nudPolygonCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCornerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHistory)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NumericUpDown nudPolygonCount;
        private NumericUpDown nudCornerCount;
        private Label label2;
        private NumericUpDown nudColorStep;
        private Label label4;
        private Label label1;
        private CheckBox cbAntiAlias;
        private NumericUpDown nudSpeed;
        private Label label3;
        private NumericUpDown nudHistory;
        private Label label5;
        private SkiaSharp.Views.Desktop.SKGLControl skglControl1;
        private Button btnFullScreen;
        private System.Windows.Forms.Timer timer1;
        private CheckBox cbFade;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Button btnVideo;
    }
}