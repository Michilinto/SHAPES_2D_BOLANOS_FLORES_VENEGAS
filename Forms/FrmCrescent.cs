using System;
using System.Drawing;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmCrescent : Form
    {
        private Crescent _shape = null;

        public FrmCrescent()
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

            double maxFit = (Math.Min(pnlCanvas.Width, pnlCanvas.Height) - 40.0) / 2.0;
            double scale = maxFit / r;
            double sr = r * scale;

            int posX = (pnlCanvas.Width - (int)(sr * 2)) / 2;
            int posY = (pnlCanvas.Height - (int)(sr * 2)) / 2;

            _shape = new Crescent(sr,
                         new Point(posX, posY),
                         Color.FromArgb(100, 100, 200));

            var real = new Crescent(r, new Point(0, 0), Color.White);
            lblPerimeter.Text = $"{real.GetPerimeter():F2}";
            lblArea.Text = $"{real.GetArea():F2}";

            pnlCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txRadius.Clear();
            lblPerimeter.Text = "...";
            lblArea.Text = "...";
            lblError.Text = "";
            _shape = null;
            pnlCanvas.Invalidate();
        }

        private void FrmCrescent_Load(object sender, EventArgs e)
        {

        }
    }
}