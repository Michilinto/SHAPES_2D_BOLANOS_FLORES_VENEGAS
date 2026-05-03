using System;
using System.Drawing;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmRightTriangle : Form
    {
        private RightTriangle _shape = null;

        public FrmRightTriangle()
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

            if (!double.TryParse(txBase.Text, out double b) || b <= 0)
            {
                lblError.Text = "⚠ La base debe ser un número positivo.";
                return;
            }
            if (!double.TryParse(txHeight.Text, out double h) || h <= 0)
            {
                lblError.Text = "⚠ La altura debe ser un número positivo.";
                return;
            }

            double scale = Math.Min((pnlCanvas.Width - 40.0) / b,
                                      (pnlCanvas.Height - 40.0) / h);
            double scaledB = b * scale;
            double scaledH = h * scale;

            int posX = (pnlCanvas.Width - (int)scaledB) / 2;
            int posY = (pnlCanvas.Height - (int)scaledH) / 2;

            _shape = new RightTriangle(scaledB, scaledH,
                         new Point(posX, posY),
                         Color.FromArgb(100, 149, 237));

            var real = new RightTriangle(b, h, new Point(0, 0), Color.White);
            lblPerimeter.Text = $"{real.GetPerimeter():F2}";
            lblArea.Text = $"{real.GetArea():F2}";

            pnlCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txBase.Clear();
            txHeight.Clear();
            lblPerimeter.Text = "...";
            lblArea.Text = "...";
            lblError.Text = "";
            _shape = null;
            pnlCanvas.Invalidate();
        }
    }
}