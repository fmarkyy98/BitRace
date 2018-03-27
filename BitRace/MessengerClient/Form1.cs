using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); ;
            sock.Connect(textBox1.Text, 2345);
            if (!sock.Connected) {
                this.Text = "Connect failed";
                return;
            }
            var sz = new Szoba(sock);
            Hide();
            sz.ShowDialog();
            Show();
        }
    }
}
