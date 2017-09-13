using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Net;


namespace MAC
{
    public partial class FrmObtenerDatosparaHabilitar : Form
    {
        public FrmObtenerDatosparaHabilitar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtengo MAC
            string mac = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        mac = nic.GetPhysicalAddress().ToString();
                    }
                }
            }
            txtMAC.Text = mac;

            // Obtengo Ip

            string strHostName = string.Empty;

            strHostName = Dns.GetHostName();

            IPAddress[] hostIPs = Dns.GetHostAddresses(strHostName);

            for (int i = 0; i < hostIPs.Length; i++)
            {
                txtNombreEquipo.Text = strHostName;
                txtNombreEquipo.ReadOnly = true;
            }

            // Direccion IP
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            txtIp.Text= localIP;
            txtIp.ReadOnly = true;

        }
        private void txtCopiar_Click(object sender, EventArgs e)
        {           
             Clipboard.SetText(txtMAC.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPruebaBD().ShowDialog();
         
        }

        private void txtIp_TextChanged(object sender, EventArgs e)
        {
            
        }

}
        }
    
    
