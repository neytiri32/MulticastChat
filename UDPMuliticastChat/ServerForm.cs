using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPMuliticastChat
{
    public partial class ServerForm : Form
    {
        UdpClient server;
        IPEndPoint endPoint;

        public ServerForm()
        {
            InitializeComponent();

            server = new UdpClient(8080);
            endPoint = null;

            IPAddress multicastaddress = IPAddress.Parse("224.0.0.1");
            server.JoinMulticastGroup(multicastaddress);

            Thread thr = new Thread(new ThreadStart(ServerStart));
            thr.Start();
            newClientButton.Enabled = true;

        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {

            if (this.messsagesHistory.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.messsagesHistory.Items.Add(text);
                this.lastMessage.Text = text;
            }
        }

        private void ServerStart()
        {
            while (true)
            {
                byte[] buffer = server.Receive(ref endPoint);

                string msg = Encoding.Unicode.GetString(buffer);
                SetText(string.Format(msg));
            }
        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.Show();
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Close();
            Application.Exit();
            Environment.Exit(1);
        }
    }
}
