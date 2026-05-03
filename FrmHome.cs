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
        private FrmRegularPolygon frmRegularPolygon = null;
        private FrmRectangle frmRectangle = null;
        private FrmRhombus frmRhombus = null;
        public FrmHome()
        {
            InitializeComponent();
        }

        private void miRegularPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRegularPolygon == null || frmRegularPolygon.IsDisposed)
            {
                frmRegularPolygon = new FrmRegularPolygon();
                frmRegularPolygon.MdiParent = this;
                frmRegularPolygon.FormBorderStyle = FormBorderStyle.None;
                frmRegularPolygon.Show();
                frmRegularPolygon.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmRegularPolygon.BringToFront();
                frmRegularPolygon.Focus();
                frmRegularPolygon.WindowState = FormWindowState.Maximized;
            }
        }

        private void miRectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRectangle == null || frmRectangle.IsDisposed)
            {
                frmRectangle = new FrmRectangle();
                frmRectangle.MdiParent = this;
                frmRectangle.FormBorderStyle = FormBorderStyle.None;
                frmRectangle.Show();
                frmRectangle.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmRectangle.BringToFront(); 
                frmRectangle.Focus();
                frmRectangle.WindowState = FormWindowState.Maximized;
            }
        }

        private void miRomboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRhombus == null || frmRhombus.IsDisposed)
            {
                frmRhombus = new FrmRhombus();
                frmRhombus.MdiParent = this;
                frmRhombus.FormBorderStyle = FormBorderStyle.None;
                frmRhombus.Show();
                frmRhombus.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmRhombus.BringToFront();
                frmRhombus.Focus();
                frmRhombus.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
