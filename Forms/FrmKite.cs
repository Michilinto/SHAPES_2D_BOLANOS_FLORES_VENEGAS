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
    public partial class FrmKite : Form
    {
        private Kite kite;
        public FrmKite()
        {
            InitializeComponent();
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

                if (!double.TryParse(txtDiagonal1.Text, out double d1) || !double.TryParse(txtDiagonal2.Text, out double d2))
                {
                    lblMessage.Text = "Los valores deben ser números válidos";
                    return;
                }

                if (d1 <= 0 || d2 <= 0)
                {
                    lblMessage.Text = "Las diagonales deben ser mayores que cero";
                    return;
                }

                kite = new Kite(new Point(50, 50), Color.Blue, d1, d2);

                lblArea.Text = kite.GetArea().ToString("F2");
                lblPerimeter.Text = kite.GetPerimeter().ToString("F2");

                lblMessage.Text = "Polígono generado correctamente";

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
            kite = null;

            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (kite != null)
            {
                kite.Draw(e.Graphics);
            }
        }
    }
}
