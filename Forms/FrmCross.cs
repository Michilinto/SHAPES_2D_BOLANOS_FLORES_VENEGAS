using System;
using System.Drawing;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmCross : Form
    {
        private Cross _shape = null;

        public FrmCross()
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

            if (!double.TryParse(txSize.Text, out double size) || size <= 0)
            {
                lblError.Text = "⚠ El tamaño total debe ser positivo.";
                return;
            }
            if (!double.TryParse(txArm.Text, out double arm) || arm <= 0)
            {
                lblError.Text = "⚠ El ancho del brazo debe ser positivo.";
                return;
            }
            if (arm >= size)
            {
                lblError.Text = "⚠ El brazo debe ser menor al tamaño total.";
                return;
            }
            if (arm < size * 0.1)
            {
                lblError.Text = "⚠ El brazo es demasiado pequeño en proporción.";
                return;
            }

            double scale = (Math.Min(pnlCanvas.Width, pnlCanvas.Height) - 40.0) / size;
            int posX = (pnlCanvas.Width - (int)(size * scale)) / 2;
            int posY = (pnlCanvas.Height - (int)(size * scale)) / 2;

            _shape = new Cross(size * scale, arm * scale,
                         new Point(posX, posY),
                         Color.FromArgb(100, 149, 237));

            var real = new Cross(size, arm, new Point(0, 0), Color.White);
            lblPerimeter.Text = $"{real.GetPerimeter():F2}";
            lblArea.Text = $"{real.GetArea():F2}";

            pnlCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txSize.Clear();
            txArm.Clear();
            lblPerimeter.Text = "...";
            lblArea.Text = "...";
            lblError.Text = "";
            _shape = null;
            pnlCanvas.Invalidate();
        }
    }
}