namespace SAC
{
    partial class FrmPruebaBd
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbdManual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTestManual = new System.Windows.Forms.Button();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTesteoAutomatico = new System.Windows.Forms.Button();
            this.txtPing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNoExito = new System.Windows.Forms.Label();
            this.lblExito = new System.Windows.Forms.Label();
            this.lblPingCaido = new System.Windows.Forms.Label();
            this.lblPingOk = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblNoExito);
            this.groupBox2.Controls.Add(this.lblExito);
            this.groupBox2.Controls.Add(this.txtPass);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtUsr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbdManual);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTestManual);
            this.groupBox2.Controls.Add(this.txtNombreEquipo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 177);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prueba Manual";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(174, 118);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(241, 20);
            this.txtPass.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña:";
            // 
            // txtUsr
            // 
            this.txtUsr.Location = new System.Drawing.Point(174, 87);
            this.txtUsr.MaxLength = 50;
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(241, 20);
            this.txtUsr.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario:";
            // 
            // txtbdManual
            // 
            this.txtbdManual.Location = new System.Drawing.Point(174, 58);
            this.txtbdManual.MaxLength = 50;
            this.txtbdManual.Name = "txtbdManual";
            this.txtbdManual.Size = new System.Drawing.Size(241, 20);
            this.txtbdManual.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de la base de datos:";
            // 
            // btnTestManual
            // 
            this.btnTestManual.Location = new System.Drawing.Point(271, 148);
            this.btnTestManual.Name = "btnTestManual";
            this.btnTestManual.Size = new System.Drawing.Size(75, 23);
            this.btnTestManual.TabIndex = 4;
            this.btnTestManual.Text = "Testear";
            this.btnTestManual.UseVisualStyleBackColor = true;
            this.btnTestManual.Click += new System.EventHandler(this.btnTestManual_Click);
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(174, 28);
            this.txtNombreEquipo.MaxLength = 50;
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(241, 20);
            this.txtNombreEquipo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre del equipo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPingCaido);
            this.groupBox1.Controls.Add(this.btnTesteoAutomatico);
            this.groupBox1.Controls.Add(this.lblPingOk);
            this.groupBox1.Controls.Add(this.txtPing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prueba Ip/Host";
            // 
            // btnTesteoAutomatico
            // 
            this.btnTesteoAutomatico.Location = new System.Drawing.Point(340, 62);
            this.btnTesteoAutomatico.Name = "btnTesteoAutomatico";
            this.btnTesteoAutomatico.Size = new System.Drawing.Size(75, 23);
            this.btnTesteoAutomatico.TabIndex = 1;
            this.btnTesteoAutomatico.Text = "Testear";
            this.btnTesteoAutomatico.UseVisualStyleBackColor = true;
            this.btnTesteoAutomatico.Click += new System.EventHandler(this.btnTesteoAutomatico_Click);
            // 
            // txtPing
            // 
            this.txtPing.Location = new System.Drawing.Point(174, 28);
            this.txtPing.Name = "txtPing";
            this.txtPing.Size = new System.Drawing.Size(241, 20);
            this.txtPing.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // lblNoExito
            // 
            this.lblNoExito.AutoSize = true;
            this.lblNoExito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoExito.ForeColor = System.Drawing.Color.Red;
            this.lblNoExito.Location = new System.Drawing.Point(5, 161);
            this.lblNoExito.Name = "lblNoExito";
            this.lblNoExito.Size = new System.Drawing.Size(245, 13);
            this.lblNoExito.TabIndex = 45;
            this.lblNoExito.Text = "La conexion con la base de datos fracaso";
            this.lblNoExito.Visible = false;
            // 
            // lblExito
            // 
            this.lblExito.AutoSize = true;
            this.lblExito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExito.ForeColor = System.Drawing.Color.Black;
            this.lblExito.Location = new System.Drawing.Point(5, 148);
            this.lblExito.Name = "lblExito";
            this.lblExito.Size = new System.Drawing.Size(260, 13);
            this.lblExito.TabIndex = 44;
            this.lblExito.Text = "La conexion con la base de datos es exitosa";
            this.lblExito.Visible = false;
            // 
            // lblPingCaido
            // 
            this.lblPingCaido.AutoSize = true;
            this.lblPingCaido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPingCaido.ForeColor = System.Drawing.Color.Red;
            this.lblPingCaido.Location = new System.Drawing.Point(5, 67);
            this.lblPingCaido.Name = "lblPingCaido";
            this.lblPingCaido.Size = new System.Drawing.Size(68, 13);
            this.lblPingCaido.TabIndex = 47;
            this.lblPingCaido.Text = "Host caido";
            this.lblPingCaido.Visible = false;
            // 
            // lblPingOk
            // 
            this.lblPingOk.AutoSize = true;
            this.lblPingOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPingOk.ForeColor = System.Drawing.Color.Black;
            this.lblPingOk.Location = new System.Drawing.Point(5, 54);
            this.lblPingOk.Name = "lblPingOk";
            this.lblPingOk.Size = new System.Drawing.Size(51, 13);
            this.lblPingOk.TabIndex = 46;
            this.lblPingOk.Text = "Host ok";
            this.lblPingOk.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPruebaBd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPruebaBd";
            this.Text = "Prueba de base de datos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbdManual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestManual;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTesteoAutomatico;
        private System.Windows.Forms.TextBox txtPing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNoExito;
        internal System.Windows.Forms.Label lblExito;
        private System.Windows.Forms.Label lblPingCaido;
        internal System.Windows.Forms.Label lblPingOk;
        private System.Windows.Forms.Button button1;
    }
}