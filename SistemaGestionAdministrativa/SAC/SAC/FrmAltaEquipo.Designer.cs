namespace SAC
{
    partial class FrmAltaEquipo
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCopiar = new System.Windows.Forms.Button();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.lblmac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(283, 149);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(127, 118);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(150, 20);
            this.txtNombreEquipo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Direccion Ip:";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(127, 71);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(150, 20);
            this.txtIp.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre del equipo:";
            // 
            // txtCopiar
            // 
            this.txtCopiar.Location = new System.Drawing.Point(283, 24);
            this.txtCopiar.Name = "txtCopiar";
            this.txtCopiar.Size = new System.Drawing.Size(75, 23);
            this.txtCopiar.TabIndex = 10;
            this.txtCopiar.Text = "Copiar";
            this.txtCopiar.UseVisualStyleBackColor = true;
            this.txtCopiar.Click += new System.EventHandler(this.txtCopiar_Click);
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(127, 26);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(150, 20);
            this.txtMAC.TabIndex = 9;
            // 
            // lblmac
            // 
            this.lblmac.AutoSize = true;
            this.lblmac.Location = new System.Drawing.Point(22, 29);
            this.lblmac.Name = "lblmac";
            this.lblmac.Size = new System.Drawing.Size(81, 13);
            this.lblmac.TabIndex = 8;
            this.lblmac.Text = "Direccion MAC:";
            // 
            // FrmAltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 195);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCopiar);
            this.Controls.Add(this.txtMAC);
            this.Controls.Add(this.lblmac);
            this.Name = "FrmAltaEquipo";
            this.Text = "Alta de equipos al sistema por MAC";
            this.Load += new System.EventHandler(this.FrmAltaEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtCopiar;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label lblmac;
    }
}