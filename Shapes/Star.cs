using System;
using System.Collections.Generic;
using System.Drawing;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class Star : IrregularPolygon
    {
        public double OuterRadius { get; set; }
        public double InnerRadius { get; set; }

        private static List<Point> ComputeVertices(double outerR, double innerR, Point pos)
        {
            var pts = new List<Point>();
            int numPoints = 5;
            double angleOffset = -Math.PI / 2;

            for (int i = 0; i < numPoints * 2; i++)
            {
                double r = (i % 2 == 0) ? outerR : innerR;
                double angle = angleOffset + i * Math.PI / numPoints;
                pts.Add(new Point(
                    pos.X + (int)(r * Math.Cos(angle)),
                    pos.Y + (int)(r * Math.Sin(angle))
                ));
            }
            return pts;
        }

        public Star(double outerRadius, double innerRadius, Point position, Color color)
            : base(ComputeVertices(outerRadius, innerRadius, position), position, color)
        {
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }

        public override double GetArea()
        {
            return 2.5 * OuterRadius * InnerRadius * Math.Sin(2 * Math.PI / 5);
        }

        public override double GetPerimeter()
        {
            double side = 2 * OuterRadius * Math.Sin(Math.PI / 5);
            return 10 * side;
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