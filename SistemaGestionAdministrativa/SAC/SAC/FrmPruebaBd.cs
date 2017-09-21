using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAC
{
    public partial class FrmPruebaBd : Form
    {
        public FrmPruebaBd()
        {
            InitializeComponent();
        }

        private void btnTestManual_Click(object sender, EventArgs e)
        {
            int conexion=0;

            ClaseSAC.bdManual(txtNombreEquipo.Text, txtbdManual.Text, txtUsr.Text, txtPass.Text, ref conexion);

            lblExito.Visible = false;
            lblNoExito.Visible = false;

            if (conexion == 0)
            {
                lblExito.Visible = false;
                lblNoExito.Visible = true;
            }
            else
            {
                lblExito.Visible = true;
                lblNoExito.Visible = false;
            }
                        
        }

        private void btnTesteoAutomatico_Click(object sender, EventArgs e)
        {
            Ping Pings = new Ping();
            int timeout = 10;

            try
            {
                if (Pings.Send(txtPing.Text, timeout).Status == IPStatus.Success)
                    {
                        lblPingOk.Visible = true;
                        lblPingCaido.Visible = false;            
                    }
            }
            catch (Exception)
            {
               lblPingOk.Visible = false;
               lblPingCaido.Visible = true;
            }
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
