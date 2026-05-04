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
    public partial class FrmElipse : Form
    {
        private Elipse elipse;
        public FrmElipse()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lblArea.Text = "Área: ";
            lblPerimeter.Text = "Perímetro: ";
            txtHeight.Text = "";
            txtWidth.Text = "";
            lblMessage.Text = "Campos limpiados";
            elipse = null;
            picCanvas.Invalidate();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double majorAxis, minorAxis;
                double altura = double.Parse(txtHeight.Text);
                double ancho = double.Parse(txtWidth.Text);
                if (altura > ancho)
                {
                    majorAxis = altura;
                    minorAxis = ancho;
                }
                else
                {
                    majorAxis = ancho;
                    minorAxis = altura;
                }

                if (majorAxis <= 0 || minorAxis <= 0)
                {
                    lblMessage.Text = "Los valores deben ser mayores a 0";
                    return;
                }
                Point position = new Point(150, 150);
                elipse = new Elipse(position, Color.Purple, majorAxis, minorAxis);
                lblArea.Text = elipse.GetArea().ToString("F2");
                lblPerimeter.Text = elipse.GetPerimeter().ToString("F2");
                lblMessage.Text = "Cálculo realizado exitosamente";
                picCanvas.Invalidate();
            }
            catch (FormatException)
            {
                lblMessage.Text = "Complete los campos correctamente";
            }
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if(elipse != null) 
            {
                elipse.Draw(e.Graphics);
            }
        }
    }
}
