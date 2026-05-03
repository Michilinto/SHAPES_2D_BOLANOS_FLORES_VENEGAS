using System;
using System.Drawing;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class Pie : Figure2D
    {
        public double Radius { get; set; }
        public double AngleDegrees { get; set; }

        public Pie(double radius, double angleDegrees, Point position, Color color)
            : base(position, color)
        {
            Radius = radius;
            AngleDegrees = angleDegrees;
        }

        public override double GetArea()
        {
            return (AngleDegrees / 360.0) * Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            double arc = (AngleDegrees / 360.0) * 2.0 * Math.PI * Radius;
            return arc + 2.0 * Radius;
        }

        public override void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float r = (float)Radius;
            float x = Position.X;
            float y = Position.Y;

            using (Brush brush = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.FillPie(brush, x, y, r * 2, r * 2, 0f, (float)AngleDegrees);
                g.DrawPie(pen, x, y, r * 2, r * 2, 0f, (float)AngleDegrees);
            }
        }
    }
}