using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class Parallelogram : IrregularPolygon
    {
        public double Base { get; set; }
        public double Side { get; set; }
        public double Angle { get; set; }

        public Parallelogram(Point position, Color color, double baseLength, double side, double angleDegrees)
            : base(GenerateVertices(position, baseLength, side, angleDegrees), position, color)
        {
            Base = baseLength;
            Side = side;
            Angle = angleDegrees;
            NumberOfSides = 4;
        }

        private static List<Point> GenerateVertices(Point position, double baseLength, double side, double angleDegrees)
        {
            double baseLengthE = baseLength * 10;
            double sideE = side * 10;
            double angleRad = angleDegrees * Math.PI / 180.0;
            double slantHeight = Math.Cos(angleRad) * sideE;
            double height = Math.Sin(angleRad) * sideE;

            List<Point> vertices = new List<Point>
            {
                position,
                new Point((int)Math.Round(position.X + baseLengthE), position.Y),
                new Point((int)Math.Round(position.X + baseLengthE + slantHeight), (int)Math.Round(position.Y + height)),
                new Point((int)Math.Round(position.X + slantHeight), (int)Math.Round(position.Y + height))
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
            double angleRad = Angle * Math.PI / 180.0;
            double height = Math.Sin(angleRad) * Side;
            return Base * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Base + Side);
        }
    }
}
