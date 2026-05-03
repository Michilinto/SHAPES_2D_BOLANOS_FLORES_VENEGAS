using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class CCircle : Curvas
    {
        public double Radius { get; set; }

        public CCircle(Point position, Color color, double radius)
            : base(position, color)
        {
            Radius = radius;
        }

        public override void Draw(Graphics g)
        {
            double scale = 10;
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(111, 171, 129)))
            using (Pen pen = new Pen(Color.FromArgb(9, 77, 29), 3))
            {
                g.FillEllipse(brush, (float)(Position.X - Radius * scale), (float)(Position.Y - Radius * scale), 
                    (float)(Radius * 2 * scale), (float)(Radius * 2 * scale));
                g.DrawEllipse(pen, (float)(Position.X - Radius * scale), (float)(Position.Y - Radius * scale), 
                    (float)(Radius * 2 * scale), (float)(Radius * 2 * scale));
            }
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
