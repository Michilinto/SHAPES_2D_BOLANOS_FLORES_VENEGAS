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
    public partial class FrmTrapezium : Form
    {
        private Trapezium trapezium;
        public FrmTrapezium()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lblArea.Text = "...";   
            lblPerimeter.Text = "...";
            txtAltura.Text = "";
            txtBaseMayor.Text = "";
            txtBaseMenor.Text = "";
            trapezium = null;
            lblMessage.Text = "Datos limpiados";
            picCanvas.Invalidate();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtBaseMayor.Text) || string.IsNullOrWhiteSpace(txtBaseMenor.Text) || string.IsNullOrWhiteSpace(txtAltura.Text))
                {
                    lblMessage.Text = "Por favor, ingrese los valores de las bases y la altura";
                    return;
                }
                if(!double.TryParse(txtBaseMayor.Text, out double baseMayor) || !double.TryParse(txtBaseMenor.Text, out double baseMenor) || !double.TryParse(txtAltura.Text, out double altura))
                {
                    lblMessage.Text = "Los valores deben ser números válidos";
                    return;
                }
                if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0)
                {
                    lblMessage.Text = "Las bases y la altura deben ser mayores que cero";
                    return;
                }
                if(baseMayor < baseMenor)
                {
                    lblMessage.Text = "La base mayor debe ser mayor o igual a la base menor";
                    return;
                }

                trapezium = new Trapezium(new Point(50, 50), Color.Black, baseMayor, baseMenor, altura);

                double area = trapezium.GetArea();
                double perimeter = trapezium.GetPerimeter();

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

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if(trapezium != null) 
            {
                trapezium.Draw(e.Graphics);
            }
        }
    }
}
