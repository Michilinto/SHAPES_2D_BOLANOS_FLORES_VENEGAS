using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class Oval : Curvas
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Oval(Point position, Color color, double majorAxis, double minorAxis)
            : base(position, color)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color))
            {
                // Dibujar un ovoide como una aproximación usando arcos y líneas
                float x = Position.X;
                float y = Position.Y;
                float majorR = (float)MajorAxis;
                float minorR = (float)MinorAxis;

                // Dibujar la parte superior (semicírculo)
                g.DrawArc(pen, x - minorR, y - majorR, minorR * 2, minorR * 2, 0, 180);

                // Dibujar los lados
                g.DrawLine(pen, x - minorR, y, x - minorR, y + majorR);
                g.DrawLine(pen, x + minorR, y, x + minorR, y + majorR);

                // Dibujar la parte inferior (punta)
                g.DrawArc(pen, x - minorR / 2, y, minorR, majorR, 0, 360);
            }
        }

        public override double GetArea()
        {
            // Aproximación del área de un ovoide
            return Math.PI * MajorAxis * MinorAxis * 0.75;
        }

        public override double GetPerimeter()
        {
            // Aproximación de Ramanujan para el perímetro de un ovoide
            double h = Math.Pow((MajorAxis - MinorAxis) / (MajorAxis + MinorAxis), 2);
            return Math.PI * (MajorAxis + MinorAxis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h))) * 0.85;
        }
    }
}
