using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class CRectangle : IrregularPolygon
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public CRectangle(Point position, Color color, double width, double height)
            : base(GenerateVertices(position, width, height), position, color)
        {
            Width = width;
            Height = height;
            NumberOfSides = 4;
        }

        private static List<Point> GenerateVertices(Point position, double width, double height)
        {
            List<Point> vertices = new List<Point>
            {
                position,
                new Point((int)Math.Round(position.X + width), position.Y),
                new Point((int)Math.Round(position.X + width), (int)Math.Round(position.Y + height)),
                new Point((int)(position.X), (int)Math.Round(position.Y + height))
            };
            return vertices;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color))
            {
                g.DrawRectangle(pen, Position.X, Position.Y, (float)Width, (float)Height);
            }
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
