using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp39
{
    public partial class Form1 : Form
    {
        Mystify3.Field field;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Render();
        }

        Bitmap bmp;
        public void Render()
        {
            if (bmp == null || bmp.Size != pictureBox1.Size)
            {
                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                field = new Mystify3.Field(pictureBox1.Width, pictureBox1.Height, 3, 5, 10);
            }

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.Clear(Color.Black);
                //gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                field.StepForward(5);

                Pen pen = new Pen(Color.White);
                foreach (var shape in field.shapes)
                {
                    pen.Color = Color.FromArgb(shape.color.ARGB);
                    for (int historicalIndex = 0; historicalIndex < shape.corners[0].Xs.Count; historicalIndex++)
                    {
                        List<Point> points = new List<Point>();
                        for (int cornerIndex = 0; cornerIndex < shape.corners.Length; cornerIndex++)
                            points.Add(new Point(
                                (int)shape.corners[cornerIndex].Xs[historicalIndex],
                                (int)shape.corners[cornerIndex].Ys[historicalIndex]
                                ));
                        points.Add(points[0]);
                        gfx.DrawLines(pen, points.ToArray());
                    }
                }
            }

            pictureBox1.Image = bmp;
        }
    }
}
