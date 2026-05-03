using System;
using System.Drawing;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmStar : Form
    {
        private Star _shape = null;

        public FrmStar()
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

            if (!double.TryParse(txOuterR.Text, out double outerR) || outerR <= 0)
            {
                lblError.Text = "⚠ El radio exterior debe ser positivo.";
                return;
            }
            if (!double.TryParse(txInnerR.Text, out double innerR) || innerR <= 0)
            {
                lblError.Text = "⚠ El radio interior debe ser positivo.";
                return;
            }
            if (innerR >= outerR)
            {
                lblError.Text = "⚠ El radio interior debe ser menor al exterior.";
                return;
            }

            double maxFit = (Math.Min(pnlCanvas.Width, pnlCanvas.Height) - 40.0) / 2.0;
            double scale = maxFit / outerR;
            Point center = new Point(pnlCanvas.Width / 2, pnlCanvas.Height / 2);

            _shape = new Star(outerR * scale, innerR * scale,
                              center, Color.FromArgb(255, 200, 0));

            var real = new Star(outerR, innerR, new Point(0, 0), Color.White);
            lblPerimeter.Text = $"{real.GetPerimeter():F2}";
            lblArea.Text = $"{real.GetArea():F2}";

            pnlCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txOuterR.Clear();
            txInnerR.Clear();
            lblPerimeter.Text = "...";
            lblArea.Text = "...";
            lblError.Text = "";
            _shape = null;
            pnlCanvas.Invalidate();
        }
    }
}