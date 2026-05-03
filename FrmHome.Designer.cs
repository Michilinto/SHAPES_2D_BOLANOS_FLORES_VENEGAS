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
            this.miRectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRomboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(777, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miPolygonToolStripMenuItem
            // 
            this.miPolygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRegularPolygonToolStripMenuItem,
            this.miIrregularPlygonToolStripMenuItem});
            this.miPolygonToolStripMenuItem.Font = new System.Drawing.Font("Ubuntu Mono Medium", 9.999999F, System.Drawing.FontStyle.Bold);
            this.miPolygonToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.miPolygonToolStripMenuItem.Name = "miPolygonToolStripMenuItem";
            this.miPolygonToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.miPolygonToolStripMenuItem.Text = "Polígonos";
            // 
            // miRegularPolygonToolStripMenuItem
            // 
            this.miRegularPolygonToolStripMenuItem.Name = "miRegularPolygonToolStripMenuItem";
            this.miRegularPolygonToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.miRegularPolygonToolStripMenuItem.Text = "Polígonos Regulares";
            this.miRegularPolygonToolStripMenuItem.Click += new System.EventHandler(this.miRegularPolygonToolStripMenuItem_Click);
            // 
            // miIrregularPlygonToolStripMenuItem
            // 
            this.miIrregularPlygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRectanguloToolStripMenuItem,
            this.miRomboToolStripMenuItem});
            this.miIrregularPlygonToolStripMenuItem.Name = "miIrregularPlygonToolStripMenuItem";
            this.miIrregularPlygonToolStripMenuItem.Size = new System.Drawing.Size(314, 26);
            this.miIrregularPlygonToolStripMenuItem.Text = "Polígonos Irregulares";
            // 
            // miCurvesToolStripMenuItem
            // 
            this.miCurvesToolStripMenuItem.Font = new System.Drawing.Font("Ubuntu Mono Medium", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miCurvesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.miCurvesToolStripMenuItem.Name = "miCurvesToolStripMenuItem";
            this.miCurvesToolStripMenuItem.Size = new System.Drawing.Size(194, 25);
            this.miCurvesToolStripMenuItem.Text = "Figuras Curveadas";
            // 
            // miSpecialToolStripMenuItem
            // 
            this.miSpecialToolStripMenuItem.Font = new System.Drawing.Font("Ubuntu Mono Medium", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miSpecialToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(98)))));
            this.miSpecialToolStripMenuItem.Name = "miSpecialToolStripMenuItem";
            this.miSpecialToolStripMenuItem.Size = new System.Drawing.Size(204, 25);
            this.miSpecialToolStripMenuItem.Text = "Figuras Especiales";
            // 
            // miRectanguloToolStripMenuItem
            // 
            this.miRectanguloToolStripMenuItem.Name = "miRectanguloToolStripMenuItem";
            this.miRectanguloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miRectanguloToolStripMenuItem.Text = "Rectangulo";
            this.miRectanguloToolStripMenuItem.Click += new System.EventHandler(this.miRectanguloToolStripMenuItem_Click);
            // 
            // miRomboToolStripMenuItem
            // 
            this.miRomboToolStripMenuItem.Name = "miRomboToolStripMenuItem";
            this.miRomboToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.miRomboToolStripMenuItem.Text = "Rombo";
            this.miRomboToolStripMenuItem.Click += new System.EventHandler(this.miRomboToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem miRectanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miRomboToolStripMenuItem;
    }
}

