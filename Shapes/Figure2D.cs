using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public abstract class Figure2D
    {
        public Point Position { get; set; }
        public Color Color { get; set; }

        public Figure2D()
        {
            Position = Point.Empty;
            Color = Color.Black;
        }

        public Figure2D(Point position, Color color)
        {
            Position = position;
            Color = color;
        }

        public abstract void Draw(Graphics g);

        public virtual double GetArea() => 0;
        public virtual double GetPerimeter() => 0;
    }
}
