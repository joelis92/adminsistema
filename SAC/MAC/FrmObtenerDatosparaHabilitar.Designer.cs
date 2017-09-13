namespace MAC
{
    partial class FrmObtenerDatosparaHabilitar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmac = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.txtCopiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmac
            // 
            this.lblmac.AutoSize = true;
            this.lblmac.Location = new System.Drawing.Point(12, 27);
            this.lblmac.Name = "lblmac";
            this.lblmac.Size = new System.Drawing.Size(81, 13);
            this.lblmac.TabIndex = 0;
            this.lblmac.Text = "Direccion MAC:";
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(117, 24);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(150, 20);
            this.txtMAC.TabIndex = 1;
            // 
            // txtCopiar
            // 
            this.txtCopiar.Location = new System.Drawing.Point(273, 22);
            this.txtCopiar.Name = "txtCopiar";
            this.txtCopiar.Size = new System.Drawing.Size(75, 23);
            this.txtCopiar.TabIndex = 2;
            this.txtCopiar.Text = "Copiar";
            this.txtCopiar.UseVisualStyleBackColor = true;
            this.txtCopiar.Click += new System.EventHandler(this.txtCopiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del equipo:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(117, 69);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(150, 20);
            this.txtIp.TabIndex = 4;
            this.txtIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Direccion Ip:";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(117, 116);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(150, 20);
            this.txtNombreEquipo.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(273, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmObtenerDatosparaHabilitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 180);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCopiar);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.lblmac);
            this.Name = "FrmObtenerDatosparaHabilitar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAC para habilitar sistemas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmac;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Button txtCopiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Button btnSalir;
    }
}

