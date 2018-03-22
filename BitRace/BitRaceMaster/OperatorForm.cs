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
using static BitRaceMaster.Enums;
using static BitRaceMaster.Enums.ConnectionState;
using static BitRaceMaster.Enums.ConnectionType;

namespace BitRaceMaster
{
    public partial class OperatorForm : Form
    {
        Socket socketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        public IPEndPoint ipEndPoint;


        public OperatorForm()
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
                    if (connectionType == TCPIP) { connect_button.Enabled = true; }
                    break;
                case building:
                    selectedColor = Color.Orange;
                    if (connectionType == TCPIP) { connect_button.Enabled = false; }
                    break;
                case connected:
                    selectedColor = Color.Green;
                    if (connectionType == TCPIP) { connect_button.Enabled = false; }
                    break;
            }
            selectedLabel.Text = connectionState.ToString();
            selectedLabel.ForeColor = selectedColor;
            Application.DoEvents();
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {

            // 0 SQLState Request.
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
                socketListener.Connect(ipEndPoint);
            }
            catch (SocketException ex)
            {
                changeConnectionState(TCPIP, disconnected);
                return;
            }
            changeConnectionState(TCPIP, connected);
        }
    }
}
