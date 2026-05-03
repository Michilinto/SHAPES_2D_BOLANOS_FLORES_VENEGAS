using System;
using System.Drawing;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmPie : Form
    {
        private Pie _shape = null;

        public FrmPie()
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

            if (!double.TryParse(txRadius.Text, out double r) || r <= 0)
            {
                lblError.Text = "⚠ El radio debe ser un número positivo.";
                return;
            }
            if (!double.TryParse(txAngle.Text, out double angle) || angle <= 0 || angle > 360)
            {
                lblError.Text = "⚠ El ángulo debe estar entre 1° y 360°.";
                return;
            }

            double maxFit = (Math.Min(pnlCanvas.Width, pnlCanvas.Height) - 40.0) / 2.0;
            double scale = maxFit / r;
            double sr = r * scale;

            int posX = (pnlCanvas.Width - (int)(sr * 2)) / 2;
            int posY = (pnlCanvas.Height - (int)(sr * 2)) / 2;

            _shape = new Pie(sr, angle,
                         new Point(posX, posY),
                         Color.FromArgb(205, 133, 63));

            var real = new Pie(r, angle, new Point(0, 0), Color.White);
            lblPerimeter.Text = $"{real.GetPerimeter():F2}";
            lblArea.Text = $"{real.GetArea():F2}";

            pnlCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txRadius.Clear();
            txAngle.Clear();
            lblPerimeter.Text = "...";
            lblArea.Text = "...";
            lblError.Text = "";
            _shape = null;
            pnlCanvas.Invalidate();
        }
    }
}