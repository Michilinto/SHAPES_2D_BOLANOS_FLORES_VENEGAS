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
        private FrmKite frmKite = null;
        private FrmParallelogram frmIrregularPolygon = null;
        private FrmTrapezium frmTrapezium = null;
        public FrmHome()
        {
            InitializeComponent();
        }
        private void miIrregularPlygonToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void cometaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKite == null || frmKite.IsDisposed)
            {
                frmKite = new FrmKite();
                frmKite.MdiParent = this;
                frmKite.FormBorderStyle = FormBorderStyle.None;
                frmKite.Show();
                frmKite.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmKite.BringToFront();
                frmKite.Focus();
                frmKite.WindowState = FormWindowState.Maximized;
            }
        }

        private void miTrapecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmTrapezium == null || frmTrapezium.IsDisposed)
            {
                frmTrapezium = new FrmTrapezium();
                frmTrapezium.MdiParent = this;
                frmTrapezium.FormBorderStyle = FormBorderStyle.None;
                frmTrapezium.Show();
                frmTrapezium.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmTrapezium.BringToFront();
                frmTrapezium.Focus();
                frmTrapezium.WindowState = FormWindowState.Maximized;
            }
        }

        private void miParalelogramoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmIrregularPolygon == null || frmIrregularPolygon.IsDisposed)
            {
                frmIrregularPolygon = new FrmParallelogram();
                frmIrregularPolygon.MdiParent = this;
                frmIrregularPolygon.FormBorderStyle = FormBorderStyle.None;
                frmIrregularPolygon.Show();
                frmIrregularPolygon.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frmIrregularPolygon.BringToFront();
                frmIrregularPolygon.Focus();
                frmIrregularPolygon.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
