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
    public partial class Szoba : Form
    {
        Socket sock;
        private Szoba()
        {
            InitializeComponent();
        }

        public Szoba(Socket sock) : this(){
            this.sock = sock;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var b = Encoding.ASCII.GetBytes(textBox1.Text);
            sock.Send(b);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!sock.Poll(0, SelectMode.SelectRead)) {
                return;
            }
            byte[] buffer = new byte[1024];
            int cnt = sock.Receive(buffer);
            listBox1.Items.Add(Encoding.ASCII.GetString(buffer, 0, cnt));
        }

        private void Szoba_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            sock.Close();
        }
    }
}
