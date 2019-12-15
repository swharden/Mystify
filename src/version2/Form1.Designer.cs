namespace MystifySharp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShapeCountNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SpeedTrackbar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.GitHubButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ComplexityTrackbar = new System.Windows.Forms.TrackBar();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.LineWidthTrackbar = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AntiAliasCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShapeCountNUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackbar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComplexityTrackbar)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthTrackbar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShapeCountNUD);
            this.groupBox1.Location = new System.Drawing.Point(546, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // ShapeCountNUD
            // 
            this.ShapeCountNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShapeCountNUD.Location = new System.Drawing.Point(6, 19);
            this.ShapeCountNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ShapeCountNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ShapeCountNUD.Name = "ShapeCountNUD";
            this.ShapeCountNUD.Size = new System.Drawing.Size(76, 20);
            this.ShapeCountNUD.TabIndex = 0;
            this.ShapeCountNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ShapeCountNUD.ValueChanged += new System.EventHandler(this.ShapeCountNUD_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SpeedTrackbar);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Line Spacing";
            // 
            // SpeedTrackbar
            // 
            this.SpeedTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedTrackbar.AutoSize = false;
            this.SpeedTrackbar.Location = new System.Drawing.Point(6, 15);
            this.SpeedTrackbar.Maximum = 15;
            this.SpeedTrackbar.Minimum = 1;
            this.SpeedTrackbar.Name = "SpeedTrackbar";
            this.SpeedTrackbar.Size = new System.Drawing.Size(160, 29);
            this.SpeedTrackbar.TabIndex = 0;
            this.SpeedTrackbar.Value = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ColorComboBox);
            this.groupBox3.Location = new System.Drawing.Point(640, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 48);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Grayscale",
            "Solid",
            "Rainbow"});
            this.ColorComboBox.Location = new System.Drawing.Point(6, 19);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(84, 21);
            this.ColorComboBox.TabIndex = 0;
            // 
            // GitHubButton
            // 
            this.GitHubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GitHubButton.Location = new System.Drawing.Point(964, 37);
            this.GitHubButton.Name = "GitHubButton";
            this.GitHubButton.Size = new System.Drawing.Size(75, 23);
            this.GitHubButton.TabIndex = 0;
            this.GitHubButton.Text = "GitHub";
            this.GitHubButton.UseVisualStyleBackColor = true;
            this.GitHubButton.Click += new System.EventHandler(this.GitHubButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1027, 489);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ComplexityTrackbar);
            this.groupBox5.Location = new System.Drawing.Point(190, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 48);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Corners";
            // 
            // ComplexityTrackbar
            // 
            this.ComplexityTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComplexityTrackbar.AutoSize = false;
            this.ComplexityTrackbar.Location = new System.Drawing.Point(6, 15);
            this.ComplexityTrackbar.Maximum = 20;
            this.ComplexityTrackbar.Minimum = 3;
            this.ComplexityTrackbar.Name = "ComplexityTrackbar";
            this.ComplexityTrackbar.Size = new System.Drawing.Size(160, 29);
            this.ComplexityTrackbar.TabIndex = 0;
            this.ComplexityTrackbar.Value = 5;
            this.ComplexityTrackbar.Scroll += new System.EventHandler(this.ComplexityTrackbar_Scroll);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Location = new System.Drawing.Point(964, 8);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.LineWidthTrackbar);
            this.groupBox6.Location = new System.Drawing.Point(368, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(172, 48);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Line Width";
            // 
            // LineWidthTrackbar
            // 
            this.LineWidthTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineWidthTrackbar.AutoSize = false;
            this.LineWidthTrackbar.Location = new System.Drawing.Point(6, 15);
            this.LineWidthTrackbar.Maximum = 15;
            this.LineWidthTrackbar.Minimum = 1;
            this.LineWidthTrackbar.Name = "LineWidthTrackbar";
            this.LineWidthTrackbar.Size = new System.Drawing.Size(160, 29);
            this.LineWidthTrackbar.TabIndex = 0;
            this.LineWidthTrackbar.Value = 1;
            this.LineWidthTrackbar.Scroll += new System.EventHandler(this.LineWidthTrackbar_Scroll);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AntiAliasCheckbox);
            this.groupBox4.Location = new System.Drawing.Point(742, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(78, 48);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // AntiAliasCheckbox
            // 
            this.AntiAliasCheckbox.AutoSize = true;
            this.AntiAliasCheckbox.Location = new System.Drawing.Point(6, 22);
            this.AntiAliasCheckbox.Name = "AntiAliasCheckbox";
            this.AntiAliasCheckbox.Size = new System.Drawing.Size(65, 17);
            this.AntiAliasCheckbox.TabIndex = 0;
            this.AntiAliasCheckbox.Text = "Antialias";
            this.AntiAliasCheckbox.UseVisualStyleBackColor = true;
            this.AntiAliasCheckbox.CheckedChanged += new System.EventHandler(this.AntiAliasCheckbox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 567);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GitHubButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MystifySharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShapeCountNUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackbar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComplexityTrackbar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LineWidthTrackbar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ShapeCountNUD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar SpeedTrackbar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Button GitHubButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar ComplexityTrackbar;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TrackBar LineWidthTrackbar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox AntiAliasCheckbox;
    }
}

