using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BitRaceServer
{
    class PlayerConnector
    {
        Socket connection;
        string input;
        string output;
        bool isRead;
        bool IsRead { get { return isRead; } }

        public string Input
        {
            get
            {
                isRead = true;
                return input;
            }
        }
        public string Output { get { return output; } set { output = value; } }

        public PlayerConnector(Socket socket)
        {
            this.connection = socket;
            new Thread(listener).Start();
        }
        private void listener()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int recieveSize = connection.Receive(buffer);
                    string input = Encoding.ASCII.GetString(buffer, 0, recieveSize);
                    if (input != this.input)
                    {
                        isRead = false;
                        this.input = input;
                    }
                }
                catch { }
            }
        }

        public void SendData()
        {
            byte[] data = Encoding.ASCII.GetBytes(output);
            connection.Send(data);
        }

    }
}
