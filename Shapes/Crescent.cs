using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class Crescent : Figure2D
    {
        public double Radius { get; set; }

        public Crescent(double radius, Point position, Color color)
            : base(position, color)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            double innerR = Radius * 0.85;
            return Math.PI * Radius * Radius - Math.PI * innerR * innerR;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius + 2 * Math.PI * (Radius * 0.85);
        }

        public override void Draw(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float r = (float)Radius;
            float x = Position.X;
            float y = Position.Y;

            // Proporciones para un corte estético
            float ir = r * 0.90f; // Radio interior ligeramente menor
            float offset = r * 0.40f; // Desplazamiento a la derecha

            // Definimos los rectángulos de los dos círculos
            RectangleF outerRect = new RectangleF(x, y, r * 2, r * 2);
            RectangleF innerRect = new RectangleF(x + offset, y + (r - ir), ir * 2, ir * 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                // 1. Añadimos el arco exterior (la parte de atrás de la luna)
                // De 90 a 270 grados en sentido horario
                path.AddArc(outerRect, 65, 230);

                // 2. Añadimos el arco interior (el corte)
                // Se añade en sentido contrario para cerrar la silueta correctamente
                path.AddArc(innerRect, 275, -190);

                path.CloseFigure();

                using (Brush brush = new SolidBrush(Color))
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    // Rellenamos la silueta combinada
                    g.FillPath(brush, path);

                    // Dibujamos el borde SOLO de la silueta
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}