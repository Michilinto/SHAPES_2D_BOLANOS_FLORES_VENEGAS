using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class Heart : Figure2D
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Heart(double width, double height, Point position, Color color)
            : base(position, color)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            double r = Width / 4.0;
            return 2.0 * Math.PI * r * r + (Width / 2.0) * (Height * 0.6);
        }

        public override double GetPerimeter()
        {
            return Math.PI * Width + 2.0 * Math.Sqrt(
                (Width / 2.0) * (Width / 2.0) + Height * Height);
        }

        public override void Draw(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float w = (float)Width;
            float h = (float)Height;
            float x = Position.X;
            float y = Position.Y;

            using (GraphicsPath path = new GraphicsPath())
            using (Brush brush = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                path.AddArc(x, y, w / 2f, h / 2f, 180f, 180f);
                path.AddArc(x + w / 2f, y, w / 2f, h / 2f, 180f, 180f);
                path.AddLine(x + w, y + h * 0.5f, x + w / 2f, y + h);
                path.AddLine(x + w / 2f, y + h, x, y + h * 0.5f);
                path.CloseFigure();

                g.FillPath(brush, path);
                g.DrawPath(pen, path);
            }
        }
    }
}