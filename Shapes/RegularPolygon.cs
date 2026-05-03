using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class RegularPolygon : Polygon
    {
        public double SideLength { get; set; }

        public RegularPolygon(int sides, double sideLength, Point position, Color color)
            : base(position, color)
        {
            NumberOfSides = sides;
            SideLength = sideLength;
        }

        public override void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (NumberOfSides < 3) return;

            PointF[] points = new PointF[NumberOfSides];

            double angle = 2 * Math.PI / NumberOfSides;

            double radiusOriginal = SideLength / (2 * Math.Sin(Math.PI / NumberOfSides));
            double scale = 5; 
            double radius = radiusOriginal * scale;

            for (int i = 0; i < NumberOfSides; i++)
            {
                double currentAngle = i * angle - Math.PI / 2;

                float x = (float)(Position.X + radius * Math.Cos(currentAngle));
                float y = (float)(Position.Y + radius * Math.Sin(currentAngle));

                points[i] = new PointF(x, y);
            }

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(111, 171, 129)))
            using (Pen pen = new Pen(Color.FromArgb(9, 77, 29), 3))
            {
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }
        }
        public override double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
        public override double GetArea()
        {
            return (NumberOfSides * Math.Pow(SideLength, 2)) /
                   (4 * Math.Tan(Math.PI / NumberOfSides));
        }
    }
}
