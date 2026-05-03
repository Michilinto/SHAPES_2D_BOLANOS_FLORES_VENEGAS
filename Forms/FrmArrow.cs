using System;
using System.Drawing;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmArrow : Form
    {
        private Arrow _shape = null;

        public FrmArrow()
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

            if (!double.TryParse(txWidth.Text, out double w) || w <= 0)
            {
                lblError.Text = "⚠ El ancho debe ser un número positivo.";
                return;
            }
            if (!double.TryParse(txHeight.Text, out double h) || h <= 0)
            {
                lblError.Text = "⚠ El alto debe ser un número positivo.";
                return;
            }

            double scale = Math.Min((pnlCanvas.Width - 40.0) / w,
                                    (pnlCanvas.Height - 40.0) / h);
            int posX = (pnlCanvas.Width - (int)(w * scale)) / 2;
            int posY = (pnlCanvas.Height - (int)(h * scale)) / 2;

            _shape = new Arrow(w * scale, h * scale,
                         new Point(posX, posY),
                         Color.DarkOrange);

            var real = new Arrow(w, h, new Point(0, 0), Color.White);
            lblPerimeter.Text = $"{real.GetPerimeter():F2}";
            lblArea.Text = $"{real.GetArea():F2}";

            pnlCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txWidth.Clear();
            txHeight.Clear();
            lblPerimeter.Text = "...";
            lblArea.Text = "...";
            lblError.Text = "";
            _shape = null;
            pnlCanvas.Invalidate();
        }
    }
}