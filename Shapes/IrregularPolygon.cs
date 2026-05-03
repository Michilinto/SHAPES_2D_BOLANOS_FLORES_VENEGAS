using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class IrregularPolygon : Polygon
    {
        public List<Point> Vertices { get; set; } = new List<Point>();

        // 🔹 Constructor vacío
        public IrregularPolygon() : base()
        {
            NumberOfSides = 0;
        }

        public IrregularPolygon(List<Point> vertices, Point position, Color color)
            : base(position, color)
        {
            Vertices = vertices;
            NumberOfSides = vertices.Count;
        }

        public override void Draw(Graphics g)
        {
            // luego implementamos
        }
    }
}
