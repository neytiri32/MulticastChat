using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDPMuliticastChat
{
    public partial class ClientForm : Form
    {
        UdpClient client;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            IPAddress multicastaddress = IPAddress.Parse("224.0.0.1");
            IPEndPoint remoteep = new IPEndPoint(multicastaddress, 8080);

            client = new UdpClient(0);
            string msg = string.Format(newMessageBox.Text.Trim());
            byte[] buff = Encoding.Unicode.GetBytes(msg);

            client.Send(buff, buff.Length, remoteep);
        }
    }
}
