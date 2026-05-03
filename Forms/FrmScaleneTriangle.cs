using System;
using System.Drawing;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmScaleneTriangle : Form
    {
        private ScaleneTriangle _shape = null;

        public FrmScaleneTriangle()
        {
            InitializeComponent();
            pnlCanvas.Paint += PnlCanvas_Paint;
        }

        private void PnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            _shape?.Draw(e.Graphics);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (!double.TryParse(txSideA.Text, out double a) || a <= 0)
            {
                lblError.Text = "⚠ El lado A debe ser un número positivo.";
                return;
            }
            if (!double.TryParse(txSideB.Text, out double b) || b <= 0)
            {
                lblError.Text = "⚠ El lado B debe ser un número positivo.";
                return;
            }
            if (!double.TryParse(txSideC.Text, out double c) || c <= 0)
            {
                lblError.Text = "⚠ El lado C debe ser un número positivo.";
                return;
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                lblError.Text = "⚠ Los lados no forman un triángulo válido.";
                return;
            }

            double x3 = (a * a + b * b - c * c) / (2.0 * a);
            double triHeight = Math.Sqrt(Math.Max(0, b * b - x3 * x3));

            double scale = Math.Min((pnlCanvas.Width - 40.0) / a,
                                    (pnlCanvas.Height - 40.0) / triHeight);

            int posX = (pnlCanvas.Width - (int)(a * scale)) / 2;
            int posY = (pnlCanvas.Height - (int)(triHeight * scale)) / 2;

            _shape = new ScaleneTriangle(a * scale, b * scale, c * scale,
                         new Point(posX, posY),
                         Color.FromArgb(205, 92, 92));

            var real = new ScaleneTriangle(a, b, c, new Point(0, 0), Color.White);
            lblPerimeter.Text = $"{real.GetPerimeter():F2}";
            lblArea.Text = $"{real.GetArea():F2}";

            pnlCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txSideA.Clear();
            txSideB.Clear();
            txSideC.Clear();
            lblPerimeter.Text = "...";
            lblArea.Text = "...";
            lblError.Text = "";
            _shape = null;
            pnlCanvas.Invalidate();
        }
    }
}