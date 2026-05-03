using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class Trapezium : IrregularPolygon
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Height { get; set; }

        public Trapezium(Point position, Color color, double baseMayor, double baseMenor, double height)
            : base(GenerateVertices(position, baseMayor, baseMenor, height), position, color)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Height = height;
            NumberOfSides = 4;
        }

        private static List<Point> GenerateVertices(Point position, double baseMayor, double baseMenor, double height)
        {
            double baseMayorE = baseMayor * 10;
            double heightE = height * 10;
            double baseMenorE = baseMenor * 10;
            double offset = (baseMayorE - baseMenorE) / 2;
            Point A = new Point((int)Math.Round(position.X + offset), position.Y);
            Point B = new Point((int)Math.Round(position.X + offset + baseMenorE), position.Y);
            Point C = new Point((int)(position.X), (int)Math.Round(position.Y + heightE));
            Point D = new Point((int)Math.Round(position.X + baseMayorE), (int)Math.Round(position.Y + heightE));
            return new List<Point> { A, B, D, C };
        }

        public override void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Point[] points = Vertices.ToArray();

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(111, 171, 129)))
            using (Pen pen = new Pen(Color.FromArgb(9, 77, 29), 3))
            {
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }
        }

        public override double GetArea()
        {
            return ((BaseMayor + BaseMenor) / 2) * Height;
        }

        public override double GetPerimeter()
        {
            double slantHeight = Math.Sqrt(Height * Height + ((BaseMayor - BaseMenor) / 2) * ((BaseMayor - BaseMenor) / 2));
            return BaseMayor + BaseMenor + 2 * slantHeight;
        }
    }
}
