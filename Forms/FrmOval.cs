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
    public partial class FrmOval : Form
    {
        private Oval oval;
        public FrmOval()
        {
            InitializeComponent();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (oval != null)
            {
                oval.Draw(e.Graphics);
            }

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
                }else
                {
                    majorAxis = ancho;
                    minorAxis = altura;
                }

                if (majorAxis <= 0 || minorAxis <= 0)
                {
                    lblMessage.Text = "Los valores deben ser mayores a 0";
                    return;
                }
                Point position = new Point(50, 50);
                oval = new Oval(position, Color.Purple, majorAxis, minorAxis);
                lblArea.Text = oval.GetArea().ToString("F2");
                lblPerimeter.Text = oval.GetPerimeter().ToString("F2");
                lblMessage.Text = "Cálculo realizado exitosamente";
                picCanvas.Invalidate();
            }
            catch (FormatException)
            {
                lblMessage.Text = "Complete los campos correctamente";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";    
            txtWidth.Text = "";
            lblArea.Text = "...";
            lblPerimeter.Text = "...";
            oval = null;
            picCanvas.Invalidate();
        }
    }
}
