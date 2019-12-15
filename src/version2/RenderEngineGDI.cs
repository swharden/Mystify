using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MystifySharp
{
    public static class RenderEngineGDI
    {
        public static void Render(Bitmap bmp, Mystify.Field field, bool antiAlias)
        {
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                if (antiAlias)
                    gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                gfx.Clear(Color.Black);
                foreach (Mystify.MovingPolygon movingPolygon in field.polygons)
                {
                    foreach (Mystify.Polygon polygon in movingPolygon.polygonHistory)
                    {
                        List<Point> points = new List<Point>();
                        for (int i = 0; i < polygon.corners.Count(); i++)
                            points.Add(new Point((int)polygon.corners[i].X, (int)polygon.corners[i].Y));
                        points.Add(points[0]);
                        Pen pen = new Pen(Color.FromArgb(polygon.color.ARGB), (float)polygon.lineWidth);
                        gfx.DrawLines(pen, points.ToArray());
                    }
                }
            }
        }
    }
}
