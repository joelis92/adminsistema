using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaWfl;



namespace MAC
{
    public partial class FrmPruebaBD : Form
    {
        public FrmPruebaBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.bdManual(txtNombreEquipo.Text, txtbdManual.Text, txtUsr.Text, txtPass.Text);
        }

        private void FrmPruebaBD_Load(object sender, EventArgs e)
        {
            ClaseWfl.prueba();
        }
    }
}
