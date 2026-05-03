using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            // Busca si el formulario ya existe en la lista de hijos
            Form formularioEncontrado = this.MdiChildren.FirstOrDefault(f => f is T);

            if (formularioEncontrado == null || formularioEncontrado.IsDisposed)
            {
                // Si no existe, crea una nueva instancia
                T nuevoFormulario = new T();
                nuevoFormulario.MdiParent = this;
                nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
                nuevoFormulario.WindowState = FormWindowState.Maximized;
                nuevoFormulario.Show();
            }
            else
            {
                formularioEncontrado.BringToFront();
                formularioEncontrado.Focus();
            }
        }

        private void miIrregularPlygonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void miRegularPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegularPolygon>();
        }

        private void miRectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRectangle>();
        }

        private void miRomboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRhombus>();
        }

        private void cometaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmKite>();
        }

        private void miTrapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmTrapezium>();
        }

        private void miParalelogramoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmParallelogram>();
        }

        private void miOvaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmOval>();
        }
    }
}
