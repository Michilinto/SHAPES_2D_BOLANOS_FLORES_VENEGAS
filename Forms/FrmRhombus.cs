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
    public partial class FrmRhombus : Form
    {
        private Rhombus rombo;
        public FrmRhombus()
        {
            InitializeComponent();
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDiagonal1.Text) || string.IsNullOrWhiteSpace(txtDiagonal2.Text))
                {
                    lblMessage.Text = "Por favor, ingrese los valores de las diagonales";
                    return;
                }

                if (!double.TryParse(txtDiagonal1.Text, out double dMayor) || !double.TryParse(txtDiagonal2.Text, out double dMenor))
                {
                    lblMessage.Text = "Los valores deben ser números válidos";
                    return;
                }

                if (dMayor <= 0 || dMenor <= 0)
                {
                    lblMessage.Text = "Las diagonales deben ser mayores que cero";
                    return;
                }

                rombo = new Rhombus(new Point(50, 50), Color.Black, dMayor, dMenor);

                double area = rombo.GetArea();
                double perimeter = rombo.GetPerimeter();

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
            lblMessage.Text = "Datos limpiados";
            txtDiagonal1.Text = "";
            txtDiagonal2.Text = "";
            rombo = null;

            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (rombo != null)
            {
                rombo.Draw(e.Graphics);
            }
        }
    }
}
