using System;
using System.Collections.Generic;
using System.Drawing;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class RightTriangle : IrregularPolygon
    {
        public double Base { get; set; }
        public double Height { get; set; }

        private static List<Point> ComputeVertices(double b, double h, Point pos)
        {
            return new List<Point>
            {
                new Point(pos.X,              pos.Y + (int)h),
                new Point(pos.X + (int)b,     pos.Y + (int)h),
                new Point(pos.X,              pos.Y)
            };
        }

        public RightTriangle(double b, double h, Point position, Color color)
            : base(ComputeVertices(b, h, position), position, color)
        {
            Base = b;
            Height = h;
        }

        public override double GetArea() => (Base * Height) / 2.0;

        public override double GetPerimeter()
        {
            double hyp = Math.Sqrt(Base * Base + Height * Height);
            return Base + Height + hyp;
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