namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS
{
    partial class FrmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRegularPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miIrregularPlygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCurvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRightTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScleneTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCrescent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCross = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArrow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(77)))), ((int)(((byte)(137)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPolygonToolStripMenuItem,
            this.miCurvesToolStripMenuItem,
            this.miSpecialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miPolygonToolStripMenuItem
            // 
            this.miPolygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRegularPolygonToolStripMenuItem,
            this.miIrregularPlygonToolStripMenuItem});
            this.miPolygonToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold);
            this.miPolygonToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.miPolygonToolStripMenuItem.Name = "miPolygonToolStripMenuItem";
            this.miPolygonToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.miPolygonToolStripMenuItem.Text = "Polígonos";
            // 
            // miRegularPolygonToolStripMenuItem
            // 
            this.miRegularPolygonToolStripMenuItem.Name = "miRegularPolygonToolStripMenuItem";
            this.miRegularPolygonToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.miRegularPolygonToolStripMenuItem.Text = "Polígonos Regulares";
            this.miRegularPolygonToolStripMenuItem.Click += new System.EventHandler(this.miRegularPolygonToolStripMenuItem_Click);
            // 
            // miIrregularPlygonToolStripMenuItem
            // 
            this.miIrregularPlygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRightTriangle,
            this.mnuScleneTriangle});
            this.miIrregularPlygonToolStripMenuItem.Name = "miIrregularPlygonToolStripMenuItem";
            this.miIrregularPlygonToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.miIrregularPlygonToolStripMenuItem.Text = "Polígonos Irregulares";
            // 
            // miCurvesToolStripMenuItem
            // 
            this.miCurvesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeart,
            this.mnuCrescent,
            this.mnuPie});
            this.miCurvesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miCurvesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.miCurvesToolStripMenuItem.Name = "miCurvesToolStripMenuItem";
            this.miCurvesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.miCurvesToolStripMenuItem.Text = "Figuras Curveadas";
            // 
            // miSpecialToolStripMenuItem
            // 
            this.miSpecialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStar,
            this.mnuCross,
            this.mnuArrow});
            this.miSpecialToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miSpecialToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.miSpecialToolStripMenuItem.Name = "miSpecialToolStripMenuItem";
            this.miSpecialToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.miSpecialToolStripMenuItem.Text = "Figuras Especiales";
            // 
            // mnuRightTriangle
            // 
            this.mnuRightTriangle.Name = "mnuRightTriangle";
            this.mnuRightTriangle.Size = new System.Drawing.Size(270, 26);
            this.mnuRightTriangle.Text = "Triángulo Rectangulo";
            this.mnuRightTriangle.Click += new System.EventHandler(this.mnuRightTriangle_Click);
            // 
            // mnuScleneTriangle
            // 
            this.mnuScleneTriangle.Name = "mnuScleneTriangle";
            this.mnuScleneTriangle.Size = new System.Drawing.Size(270, 26);
            this.mnuScleneTriangle.Text = "Triángulo Escaleno";
            this.mnuScleneTriangle.Click += new System.EventHandler(this.mnuScleneTriangle_Click);
            // 
            // mnuHeart
            // 
            this.mnuHeart.Name = "mnuHeart";
            this.mnuHeart.Size = new System.Drawing.Size(224, 26);
            this.mnuHeart.Text = "Corazón";
            this.mnuHeart.Click += new System.EventHandler(this.mnuHeart_Click);
            // 
            // mnuCrescent
            // 
            this.mnuCrescent.Name = "mnuCrescent";
            this.mnuCrescent.Size = new System.Drawing.Size(224, 26);
            this.mnuCrescent.Text = "Media Luna";
            this.mnuCrescent.Click += new System.EventHandler(this.mnuCrescent_Click);
            // 
            // mnuPie
            // 
            this.mnuPie.Name = "mnuPie";
            this.mnuPie.Size = new System.Drawing.Size(224, 26);
            this.mnuPie.Text = "Pie";
            this.mnuPie.Click += new System.EventHandler(this.mnuPie_Click);
            // 
            // mnuStar
            // 
            this.mnuStar.Name = "mnuStar";
            this.mnuStar.Size = new System.Drawing.Size(224, 26);
            this.mnuStar.Text = "Estrella";
            this.mnuStar.Click += new System.EventHandler(this.mnuStar_Click);
            // 
            // mnuCross
            // 
            this.mnuCross.Name = "mnuCross";
            this.mnuCross.Size = new System.Drawing.Size(224, 26);
            this.mnuCross.Text = "Cruz";
            this.mnuCross.Click += new System.EventHandler(this.mnuCross_Click);
            // 
            // mnuArrow
            // 
            this.mnuArrow.Name = "mnuArrow";
            this.mnuArrow.Size = new System.Drawing.Size(224, 26);
            this.mnuArrow.Text = "Flecha";
            this.mnuArrow.Click += new System.EventHandler(this.mnuArrow_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 456);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miPolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRegularPolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miIrregularPlygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCurvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSpecialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRightTriangle;
        private System.Windows.Forms.ToolStripMenuItem mnuScleneTriangle;
        private System.Windows.Forms.ToolStripMenuItem mnuHeart;
        private System.Windows.Forms.ToolStripMenuItem mnuCrescent;
        private System.Windows.Forms.ToolStripMenuItem mnuPie;
        private System.Windows.Forms.ToolStripMenuItem mnuCross;
        private System.Windows.Forms.ToolStripMenuItem mnuArrow;
        private System.Windows.Forms.ToolStripMenuItem mnuStar;
    }
}

