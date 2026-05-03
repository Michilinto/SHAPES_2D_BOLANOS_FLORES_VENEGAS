using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

<<<<<<< HEAD
        /// <summary>
        /// Método genérico para abrir cualquier formulario dentro del contenedor MDI.
        /// Evita duplicados y maximiza la ventana hija.
        /// </summary>
=======
>>>>>>> c27a4ea54ab17569d5270a48eaa7a9c6781048d9
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

<<<<<<< HEAD
=======
        private void miIrregularPlygonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
>>>>>>> c27a4ea54ab17569d5270a48eaa7a9c6781048d9

        private void miRegularPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRegularPolygon>();
        }

<<<<<<< HEAD
        private void mnuRightTriangle_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmRightTriangle>();
        }

        private void mnuScleneTriangle_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmScaleneTriangle>();
        }

        private void mnuHeart_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmHeart>();
        }

        private void mnuCrescent_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCrescent>();
        }

        private void mnuPie_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPie>();
        }

        private void mnuStar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmStar>();
        }

        private void mnuCross_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCross>();
        }

        private void mnuArrow_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmArrow>();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
=======
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
>>>>>>> c27a4ea54ab17569d5270a48eaa7a9c6781048d9
        }
    }
}