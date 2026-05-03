using System;
using System.Collections.Generic;
using System.Drawing;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class Cross : IrregularPolygon
    {
        public double TotalSize { get; set; }
        public double ArmWidth { get; set; }

        private static List<Point> ComputeVertices(double t, double a, Point pos)
        {
            double m = (t - a) / 2.0;
            int x = pos.X, y = pos.Y;

            return new List<Point>
            {
                new Point(x + (int)m,           y),
                new Point(x + (int)(m + a),     y),
                new Point(x + (int)(m + a),     y + (int)m),
                new Point(x + (int)t,           y + (int)m),
                new Point(x + (int)t,           y + (int)(m + a)),
                new Point(x + (int)(m + a),     y + (int)(m + a)),
                new Point(x + (int)(m + a),     y + (int)t),
                new Point(x + (int)m,           y + (int)t),
                new Point(x + (int)m,           y + (int)(m + a)),
                new Point(x,                    y + (int)(m + a)),
                new Point(x,                    y + (int)m),
                new Point(x + (int)m,           y + (int)m),
            };
        }

        public Cross(double totalSize, double armWidth, Point position, Color color)
            : base(ComputeVertices(totalSize, armWidth, position), position, color)
        {
            TotalSize = totalSize;
            ArmWidth = armWidth;
        }

        public override double GetArea()
        {
            return TotalSize * ArmWidth * 2 - ArmWidth * ArmWidth;
        }

        public override double GetPerimeter()
        {
            return 8 * ((TotalSize - ArmWidth) / 2) + 4 * ArmWidth;
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