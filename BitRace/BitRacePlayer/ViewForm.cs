using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BitRacePlayer.Enums;
using static BitRacePlayer.Enums.ConnectionState;
using static BitRacePlayer.Enums.ConnectionType;

namespace BitRacePlayer
{
    public partial class ViewForm : Form
    {
        Socket connection = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        public IPEndPoint ipEndPoint;

        public ViewForm()
        {
            InitializeComponent();
            changeConnectionState(MSSQL, disconnected);
            changeConnectionState(TCPIP, disconnected);
        }

        private void changeConnectionState(ConnectionType connectionType, Enums.ConnectionState connectionState)
        {
            ToolStripStatusLabel selectedLabel = null;
            Color selectedColor = Color.Gray;

            switch (connectionType)
            {
                case MSSQL:
                    selectedLabel = SQL_StatusLabel;
                    break;
                case TCPIP:
                    selectedLabel = TCP_StatusLabel;
                    break;
            }
            switch (connectionState)
            {
                case disconnected:
                    selectedColor = Color.Red;
                    if (connectionType == TCPIP)
                    {
                        connect_button.Enabled = true;
                        timer1.Stop();
                    }
                    break;
                case building:
                    selectedColor = Color.Orange;
                    if (connectionType == TCPIP) { connect_button.Enabled = false; }
                    break;
                case connected:
                    selectedColor = Color.Green;
                    if (connectionType == TCPIP)
                    {
                        connect_button.Enabled = false;
                        timer1.Start();
                    }
                    break;
            }
            selectedLabel.Text = connectionState.ToString();
            selectedLabel.ForeColor = selectedColor;
            Application.DoEvents();
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            IPAddress hostIP = null;
            int requiredPort;
            IPAddress.TryParse(ipAdress_textBox.Text, out hostIP);
            int.TryParse(portNumber_textBox.Text, out requiredPort);
            ipEndPoint = new IPEndPoint(hostIP, requiredPort);
            try
            {
                changeConnectionState(TCPIP, building);
                connection.Connect(ipEndPoint);
            }
            catch (SocketException ex)
            {
                changeConnectionState(TCPIP, disconnected);
                return;
            }
            changeConnectionState(TCPIP, connected);
            connection.Send(Encoding.ASCII.GetBytes("request;sql"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "ansver;";
            if (radioButtonA.Checked)
            {
                message += "a";
            }
            else if (radioButtonB.Checked)
            {
                message += "b";
            }
            else if (radioButtonC.Checked)
            {
                message += "c";
            }
            else
            {
                message += "d";
            }
            var b = Encoding.ASCII.GetBytes(message);
            connection.Send(b);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
