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
        IPEndPoint ipEndPoint;
        string name;
        public ViewForm()
        {
            InitializeComponent();
            changeConnectionState(MSSQL, disconnected);
            changeConnectionState(TCPIP, disconnected);
            submit_button.Enabled = false;
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
                if (connection.IsBound && !connection.Connected)
                    connection = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                changeConnectionState(TCPIP, building);
                connection.Connect(ipEndPoint);
            }
            catch (SocketException ex)
            {
                changeConnectionState(TCPIP, disconnected);
                return;
            }
            changeConnectionState(TCPIP, connected);
            connection.Send(Encoding.ASCII.GetBytes("mssql"));
            submit_button.Enabled = true;
            if (name != null)
            {
                string message = $"register;{name}";
                byte[] data = Encoding.ASCII.GetBytes(message);
                try
                {
                    connection.Send(data);
                }
                catch (SocketException)
                {
                    changeConnectionState(TCPIP, disconnected);
                }
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"If you choose this name:{name_textBox.Text} you won't be able to change. Are you sure about your choice?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                return;
            }
            name = name_textBox.Text;            
            submit_button.Enabled = false;
            name_textBox.ReadOnly = true;

            string message = $"register;{name}";
            byte[] data = Encoding.ASCII.GetBytes(message);
            try
            {
                connection.Send(data);
            }
            catch (SocketException)
            {
                changeConnectionState(TCPIP, disconnected);
            }
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            error_StatusLabel.Text = "";
            DialogResult dr = MessageBox.Show("Are you sure about your choice?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                return;
            }

            string message = $"answer;{name};";
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
            else if (radioButtonD.Checked)
            {
                message += "d";
            }
            else
            {
                error_StatusLabel.Text = "No answer choosen.";
                return;
            }

            byte[] data = Encoding.ASCII.GetBytes(message);
            try
            {
                connection.Send(data);
            }
            catch (SocketException)
            {
                changeConnectionState(TCPIP, disconnected);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!connection.Poll(0, SelectMode.SelectRead))
            {
                return;
            }
            try
            {
                byte[] buffer = new byte[1024];
                int recieveSize = connection.Receive(buffer);
                string input = Encoding.ASCII.GetString(buffer, 0, recieveSize);
                string[] splitedInput = input.Split(';');

                if (splitedInput[0] == "mssql")
                {
                    ConnectionType currentConnectionType = MSSQL;
                    Enums.ConnectionState currentConnectionState = ToConnectionState(splitedInput[1]);
                    changeConnectionState(currentConnectionType, currentConnectionState);
                }
                else if (splitedInput[0] == "question")
                {
                    textBoxQuestion.Text = splitedInput[1];
                    radioButtonA.Text = splitedInput[2];
                    radioButtonB.Text = splitedInput[3];
                    radioButtonC.Text = splitedInput[4];
                    radioButtonD.Text = splitedInput[5];
                }
            }
            catch (SocketException ex)
            {
                connection.Shutdown(SocketShutdown.Both);
                connection.Close();
                changeConnectionState(TCPIP, disconnected);
                changeConnectionState(MSSQL, disconnected);
            }
        }
    }
}
