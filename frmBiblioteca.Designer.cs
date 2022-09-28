namespace pryPeraltaRoureTP1
{
    partial class frmBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBiblioteca));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDistribuidor = new System.Windows.Forms.Label();
            this.lblCodigoMostrar = new System.Windows.Forms.Label();
            this.lblLibroMostrar = new System.Windows.Forms.Label();
            this.lblEditorialMostrar = new System.Windows.Forms.Label();
            this.lblAutorMostar = new System.Windows.Forms.Label();
            this.lblDistribuidorMostrar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(14, 79);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(107, 16);
            this.lblLibro.TabIndex = 1;
            this.lblLibro.Text = "Nombre del libro";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(14, 125);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(59, 16);
            this.lblEditorial.TabIndex = 2;
            this.lblEditorial.Text = "Editorial ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo Autor";
            // 
            // lblDistribuidor
            // 
            this.lblDistribuidor.AutoSize = true;
            this.lblDistribuidor.Location = new System.Drawing.Point(14, 217);
            this.lblDistribuidor.Name = "lblDistribuidor";
            this.lblDistribuidor.Size = new System.Drawing.Size(75, 16);
            this.lblDistribuidor.TabIndex = 4;
            this.lblDistribuidor.Text = "Distribuidor";
            // 
            // lblCodigoMostrar
            // 
            this.lblCodigoMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblCodigoMostrar.Location = new System.Drawing.Point(155, 23);
            this.lblCodigoMostrar.Name = "lblCodigoMostrar";
            this.lblCodigoMostrar.Size = new System.Drawing.Size(49, 23);
            this.lblCodigoMostrar.TabIndex = 5;
            // 
            // lblLibroMostrar
            // 
            this.lblLibroMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLibroMostrar.Location = new System.Drawing.Point(155, 70);
            this.lblLibroMostrar.Name = "lblLibroMostrar";
            this.lblLibroMostrar.Size = new System.Drawing.Size(219, 23);
            this.lblLibroMostrar.TabIndex = 6;
            // 
            // lblEditorialMostrar
            // 
            this.lblEditorialMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblEditorialMostrar.Location = new System.Drawing.Point(155, 115);
            this.lblEditorialMostrar.Name = "lblEditorialMostrar";
            this.lblEditorialMostrar.Size = new System.Drawing.Size(111, 23);
            this.lblEditorialMostrar.TabIndex = 7;
            // 
            // lblAutorMostar
            // 
            this.lblAutorMostar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblAutorMostar.Location = new System.Drawing.Point(155, 163);
            this.lblAutorMostar.Name = "lblAutorMostar";
            this.lblAutorMostar.Size = new System.Drawing.Size(52, 23);
            this.lblAutorMostar.TabIndex = 8;
            // 
            // lblDistribuidorMostrar
            // 
            this.lblDistribuidorMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDistribuidorMostrar.Location = new System.Drawing.Point(152, 210);
            this.lblDistribuidorMostrar.Name = "lblDistribuidorMostrar";
            this.lblDistribuidorMostrar.Size = new System.Drawing.Size(114, 23);
            this.lblDistribuidorMostrar.TabIndex = 9;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.SlateGray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Location = new System.Drawing.Point(9, 276);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 33);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Anterior";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.SlateGray;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Location = new System.Drawing.Point(274, 276);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 33);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(386, 321);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDistribuidorMostrar);
            this.Controls.Add(this.lblAutorMostar);
            this.Controls.Add(this.lblEditorialMostrar);
            this.Controls.Add(this.lblLibroMostrar);
            this.Controls.Add(this.lblCodigoMostrar);
            this.Controls.Add(this.lblDistribuidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBiblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.frmBiblioteca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDistribuidor;
        private System.Windows.Forms.Label lblCodigoMostrar;
        private System.Windows.Forms.Label lblLibroMostrar;
        private System.Windows.Forms.Label lblEditorialMostrar;
        private System.Windows.Forms.Label lblAutorMostar;
        private System.Windows.Forms.Label lblDistribuidorMostrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

