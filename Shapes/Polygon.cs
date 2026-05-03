using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public abstract class Polygon : Figure2D
    {
        public int NumberOfSides { get; protected set; }

        public Polygon() : base() { }

        public Polygon(Point position, Color color)
            : base(position, color)
        {
        }
    }
}
