using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class Rhombus : IrregularPolygon
    {
        public double Diagonal1 { get; set; }
        public double Diagonal2 { get; set; }

        public Rhombus(Point position, Color color, double diagonal1, double diagonal2)
            : base(GenerateVertices(position, diagonal1, diagonal2), position, color)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
            NumberOfSides = 4;
        }

        private static List<Point> GenerateVertices(Point position, double diagonal1, double diagonal2)
        {
            double scale = 10;
            double halfD1 = (diagonal1 * scale) / 2;
            double halfD2 = (diagonal2 * scale) / 2;

            List<Point> vertices = new List<Point>
            {
                new Point((int)(position.X + halfD1), position.Y),
                new Point((int)(position.X + diagonal1*scale), (int)(position.Y + halfD2)),
                new Point((int)(position.X + halfD1), (int)(position.Y + diagonal2*scale)),
                new Point(position.X, (int)(position.Y + halfD2))
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
            double side = Math.Sqrt((Diagonal1 / 2) * (Diagonal1 / 2) + (Diagonal2 / 2) * (Diagonal2 / 2));
            return 4 * side;
        }
    }
}
