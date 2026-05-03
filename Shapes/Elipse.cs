using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class Elipse : Curvas
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Elipse(Point position, Color color, double majorAxis, double minorAxis)
            : base(position, color)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }

        public override void Draw(Graphics g)
        {
            double scale = 10;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(111, 171, 129)))
            using (Pen pen = new Pen(Color.FromArgb(9, 77, 29), 3))
            {
                g.FillEllipse(brush, (float)(Position.X - MajorAxis * scale), (float)(Position.Y - MinorAxis * scale),
                    (float)(MajorAxis * 2 * scale), (float)(MinorAxis * 2 * scale));
                g.DrawEllipse(pen, (float)(Position.X - MajorAxis * scale), (float)(Position.Y - MinorAxis * scale),
                    (float)(MajorAxis * 2 * scale), (float)(MinorAxis * 2 * scale));
            }
        }

        public override double GetArea()
        {
            return Math.PI * MajorAxis * MinorAxis;
        }

        public override double GetPerimeter()
        {
            // Aproximación de Ramanujan para el perímetro de una elipse
            double h = Math.Pow((MajorAxis - MinorAxis) / (MajorAxis + MinorAxis), 2);
            return Math.PI * (MajorAxis + MinorAxis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }
    }
}
