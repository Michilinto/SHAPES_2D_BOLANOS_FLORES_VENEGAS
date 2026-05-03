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
    public partial class FrmParallelogram : Form
    {
        private Parallelogram parallelogram;
        public FrmParallelogram()
        {
            InitializeComponent();
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
       
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtBase.Text) || string.IsNullOrEmpty(txtLado.Text) || string.IsNullOrEmpty(txtAngulo.Text))
                {
                    lblMessage.Text = "Por favor, ingrese todos los valores";
                    return;
                }
                if(!double.TryParse(txtBase.Text, out double baseLength) || !double.TryParse(txtLado.Text, out double side) || !double.TryParse(txtAngulo.Text, out double angle))
                {
                    lblMessage.Text = "Los valores deben ser números válidos";
                    return;
                }
                if (baseLength <= 0 || side <= 0)
                {
                    lblMessage.Text = "La base y el lado deben ser mayores que cero";
                    return;
                }
                if (angle <= 0 || angle >= 180)
                {
                    lblMessage.Text = "El ángulo debe ser mayor que 0 y menor que 180";
                    return;
                }
                parallelogram = new Parallelogram(new Point(50, 50), Color.Black, baseLength, side, angle);

                double area = parallelogram.GetArea();
                double perimeter = parallelogram.GetPerimeter();

                lblArea.Text = area.ToString("F2");
                lblPerimeter.Text = perimeter.ToString("F2");
                lblMessage.Text = "Cálculo completado exitosamente";

                picCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lblArea.Text = "...";
            lblPerimeter.Text = "...";
            txtBase.Text = "";
            txtAngulo.Text = "";
            txtLado.Text = "";
            parallelogram = null;
            lblMessage.Text = "Datos limpiados";

            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (parallelogram != null)
            {
                parallelogram.Draw(e.Graphics);
            }
        }
    }
}
