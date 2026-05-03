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
    public partial class FrmCircle : Form
    {
        private CCircle circle;
        public FrmCircle()
        {
            InitializeComponent();
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtRadius.Text, out double radius))
                {
                    lblMessage.Text = "Complete el campo correctamente";
                    return;
                }
                if (radius <= 0)
                {
                    lblMessage.Text = "El valor debe ser mayor a 0";
                    return;
                }
                double diameter = radius * 2;
                Point position = new Point(50, 50);
                circle = new CCircle(position, Color.Orange, diameter);
                lblArea.Text = circle.GetArea().ToString("F2");
                lblPerimeter.Text = circle.GetPerimeter().ToString("F2");
                lblMessage.Text = "Círculo calculado correctamente";
                picCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lblPerimeter.Text = "Perímetro: ";
            lblArea.Text = "Área: ";
            txtRadius.Text = "";
            circle = null;
            lblMessage.Text = "Campos limpiados";
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if(circle != null)
            {
                circle.Draw(e.Graphics);
            }
        }
    }
}
