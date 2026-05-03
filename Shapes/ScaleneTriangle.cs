using System;
using System.Collections.Generic;
using System.Drawing;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class ScaleneTriangle : IrregularPolygon
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        private static List<Point> ComputeVertices(double a, double b, double c, Point pos)
        {
            double x3 = (a * a + b * b - c * c) / (2.0 * a);
            double y3 = Math.Sqrt(Math.Max(0, b * b - x3 * x3));

            return new List<Point>
            {
                new Point(pos.X,              pos.Y + (int)y3),
                new Point(pos.X + (int)a,     pos.Y + (int)y3),
                new Point(pos.X + (int)x3,    pos.Y)
            };
        }

        public ScaleneTriangle(double a, double b, double c, Point position, Color color)
            : base(ComputeVertices(a, b, c, position), position, color)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double GetPerimeter() => SideA + SideB + SideC;

        public override double GetArea()
        {
            double s = GetPerimeter() / 2.0;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
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