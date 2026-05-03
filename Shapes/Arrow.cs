using System;
using System.Collections.Generic;
using System.Drawing;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class Arrow : IrregularPolygon
    {
        public double TotalWidth { get; set; }
        public double TotalHeight { get; set; }

        private static List<Point> ComputeVertices(double w, double h, Point pos)
        {
            double bodyW = w * 0.60;
            double bodyH = h * 0.40;
            double bodyTop = (h - bodyH) / 2.0;
            int x = pos.X, y = pos.Y;

            return new List<Point>
            {
                new Point(x,                   y + (int)bodyTop),
                new Point(x + (int)bodyW,      y + (int)bodyTop),
                new Point(x + (int)bodyW,      y),
                new Point(x + (int)w,          y + (int)(h / 2.0)),
                new Point(x + (int)bodyW,      y + (int)h),
                new Point(x + (int)bodyW,      y + (int)(bodyTop + bodyH)),
                new Point(x,                   y + (int)(bodyTop + bodyH)),
            };
        }

        public Arrow(double totalWidth, double totalHeight, Point position, Color color)
            : base(ComputeVertices(totalWidth, totalHeight, position), position, color)
        {
            TotalWidth = totalWidth;
            TotalHeight = totalHeight;
        }

        public override double GetArea()
        {
            double bodyW = TotalWidth * 0.60;
            double bodyH = TotalHeight * 0.40;
            double triH = TotalWidth * 0.40;
            return bodyW * bodyH + (TotalHeight * triH) / 2.0;
        }

        public override double GetPerimeter()
        {
            double bodyW = TotalWidth * 0.60;
            double bodyH = TotalHeight * 0.40;
            double notch = (TotalHeight - bodyH) / 2.0;
            double triH = TotalWidth * 0.40;
            double slant = Math.Sqrt(triH * triH + (TotalHeight / 2.0) * (TotalHeight / 2.0));
            return 2 * (bodyW + notch + triH + slant) + bodyH;
        }

        public override void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Point[] pts = Vertices.ToArray();
            using (Brush brush = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.FillPolygon(brush, pts);
                g.DrawPolygon(pen, pts);
            }
        }
    }
}