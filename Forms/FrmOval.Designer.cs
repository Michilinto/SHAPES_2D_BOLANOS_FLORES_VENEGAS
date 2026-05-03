namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    partial class FrmOval
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblSubtitle3 = new System.Windows.Forms.Label();
            this.lblSubtitle4 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 41);
            this.panel1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitulo.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(17, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ovalo";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Location = new System.Drawing.Point(14, 69);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(5);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(480, 336);
            this.picCanvas.TabIndex = 6;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblMessage.Location = new System.Drawing.Point(12, 44);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(32, 18);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "...";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.btnCalcular);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblTitle2);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(512, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 378);
            this.panel2.TabIndex = 11;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClean.Font = new System.Drawing.Font("Ubuntu Mono", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(80, 320);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(94, 27);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Limpiar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(98)))), ((int)(((byte)(69)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalcular.Font = new System.Drawing.Font("Ubuntu Mono", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCalcular.Location = new System.Drawing.Point(80, 273);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 27);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel4.Controls.Add(this.lblArea);
            this.panel4.Controls.Add(this.lblPerimeter);
            this.panel4.Controls.Add(this.lblSubtitle3);
            this.panel4.Controls.Add(this.lblSubtitle4);
            this.panel4.Location = new System.Drawing.Point(15, 174);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 79);
            this.panel4.TabIndex = 6;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(69, 45);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 18);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "...";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(111, 11);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(32, 18);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "...";
            // 
            // lblSubtitle3
            // 
            this.lblSubtitle3.AutoSize = true;
            this.lblSubtitle3.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSubtitle3.Location = new System.Drawing.Point(8, 11);
            this.lblSubtitle3.Name = "lblSubtitle3";
            this.lblSubtitle3.Size = new System.Drawing.Size(88, 18);
            this.lblSubtitle3.TabIndex = 0;
            this.lblSubtitle3.Text = "Perímetro:";
            // 
            // lblSubtitle4
            // 
            this.lblSubtitle4.AutoSize = true;
            this.lblSubtitle4.Font = new System.Drawing.Font("Ubuntu Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSubtitle4.Location = new System.Drawing.Point(8, 45);
            this.lblSubtitle4.Name = "lblSubtitle4";
            this.lblSubtitle4.Size = new System.Drawing.Size(48, 18);
            this.lblSubtitle4.TabIndex = 2;
            this.lblSubtitle4.Text = "Área:";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblTitle2.Location = new System.Drawing.Point(21, 142);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(98, 23);
            this.lblTitle2.TabIndex = 6;
            this.lblTitle2.Text = "Cálculos";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Ubuntu Mono", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblTitle.Location = new System.Drawing.Point(21, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Datos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.txtHeight);
            this.panel3.Controls.Add(this.lblSubtitle);
            this.panel3.Controls.Add(this.txtWidth);
            this.panel3.Controls.Add(this.lblSubtitle2);
            this.panel3.Location = new System.Drawing.Point(15, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 79);
            this.panel3.TabIndex = 5;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(84, 10);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(139, 22);
            this.txtHeight.TabIndex = 4;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Ubuntu Mono", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSubtitle.Location = new System.Drawing.Point(8, 11);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(80, 21);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Altura:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(84, 46);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(139, 22);
            this.txtWidth.TabIndex = 3;
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Font = new System.Drawing.Font("Ubuntu Mono", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSubtitle2.Location = new System.Drawing.Point(8, 45);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(70, 21);
            this.lblSubtitle2.TabIndex = 2;
            this.lblSubtitle2.Text = "Ancho:";
            // 
            // FrmOval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(772, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmOval";
            this.Text = "FrmOval";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblSubtitle3;
        private System.Windows.Forms.Label lblSubtitle4;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblSubtitle2;
    }
}