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

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS
{
    public partial class FrmRectangle : Form
    {
        private CRectangle rectangle;
        public FrmRectangle()
        {
            InitializeComponent();
        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {

            lblArea.Text = "...";
            lblPerimeter.Text = "...";
            lblMessage.Text = "Datos limpiados";
            txtHeight.Text = "";
            txtWidth.Text = "";
            rectangle = null;

            picCanvas.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double width, height;
            if (!double.TryParse(txtWidth.Text, out width) || !double.TryParse(txtHeight.Text, out height))
            {
                lblMessage.Text = "Complete los campos correctamente";
                return;
            }

            if (width <= 0 || height <= 0)
            {
                lblMessage.Text = "Los valores deben ser mayores a 0";
                return;
            }

            Point position = new Point(50, 50);

            rectangle = new CRectangle(position, Color.Blue, width, height);

            lblArea.Text = rectangle.GetArea().ToString("F2");
            lblPerimeter.Text = rectangle.GetPerimeter().ToString("F2");

            picCanvas.Invalidate();
            lblMessage.Text = "Polígono generado correctamente";
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (rectangle != null)
            {
                rectangle.Draw(e.Graphics);
            }
        }
    }
}
