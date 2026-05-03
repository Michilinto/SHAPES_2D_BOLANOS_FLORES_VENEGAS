using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class Kite : IrregularPolygon
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        public Kite(Point position, Color color, double diagonal1, double diagonal2)
            : base(GenerateVertices(position, diagonal1, diagonal2), position, color)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
            NumberOfSides = 4;
        }

        private static List<Point> GenerateVertices(Point position, double diagonal1, double diagonal2)
        {
            double scaledD1 = diagonal1 * 10;
            double scaledD2 = diagonal2 * 10;
            double d1Offset = scaledD1 / 3;
            double halfD2 = scaledD2 / 2;

            List<Point> vertices = new List<Point>
            {
                new Point((int)(position.X + halfD2), position.Y),
                new Point((int)(position.X + scaledD2), (int)(position.Y + d1Offset)),
                new Point((int)(position.X + halfD2), (int)(position.Y + scaledD1)),
                new Point(position.X, (int)(position.Y + d1Offset))
            };
            return vertices;
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
            return (Diagonal1 * Diagonal2) / 2;
        }

        public override double GetPerimeter()
        {
            // Kite has two pairs of equal sides
            double d1Offset = Diagonal1 / 3;
            double halfD2 = Diagonal2 / 2;

            double side1 = Math.Sqrt(halfD2 * halfD2 + d1Offset * d1Offset);
            double side2 = Math.Sqrt(halfD2 * halfD2 + (Diagonal1 - d1Offset) * (Diagonal1 - d1Offset));

            return 2 * (side1 + side2);
        }
    }
}
