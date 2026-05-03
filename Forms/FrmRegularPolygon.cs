using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmRegularPolygon : Form
    {
        RegularPolygon polygon;
        public FrmRegularPolygon()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            picCanvas.Paint += picCanvas_Paint;
            btnCalcular.Click += btnCalcular_Click;
            btnClean.Click += btnClean_Click;
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (polygon != null)
            {
                polygon.Draw(e.Graphics);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int lados = (int)nudSides.Value;

            if (!double.TryParse(txtRadio.Text, out double longitud) || longitud <= 0)
            {
                lblMessage.Text = "Ingrese una longitud válida mayor a 0";
                return;
            }

            polygon = new RegularPolygon(
                lados,
                longitud,
                new Point(picCanvas.Width / 2, picCanvas.Height / 2),
                Color.Black
            );

            lblPerimeter.Text = polygon.GetPerimeter().ToString("F2");
            lblArea.Text = polygon.GetArea().ToString("F2");

            lblMessage.Text = "Polígono generado correctamente";

            picCanvas.Invalidate();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            polygon = null;

            lblArea.Text = "...";
            lblPerimeter.Text = "...";
            lblMessage.Text = "Datos limpiados";

            picCanvas.Invalidate();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            picCanvas.Paint -= picCanvas_Paint;
            base.OnFormClosing(e);
        }
    }
}
