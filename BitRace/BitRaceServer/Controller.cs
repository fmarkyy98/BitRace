using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static BitRaceServer.Enums;
using static BitRaceServer.Enums.ConnectionState;

namespace BitRaceServer
{
    class Controller
    {
        static Game game = new Game(10, 3, 3);
        static ConnectionState sqlState;

        static void Main(string[] args)
        {
            Socket connection = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            connection.Bind(new IPEndPoint(new IPAddress(new byte[] { 127, 0, 0, 1 }), 8912));
            connection.Listen(0);
            try
            {
                MSSQLConnector.BuildConnection("string", "string", "string", "string");
                Controller.sqlState = building;
                Console.WriteLine("Connection was succesfully built.");
                Controller.sqlState = connected;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                Controller.sqlState = disconnected;
            }
            Console.WriteLine("Started Listening at LocalHost:8912");
            while (true)
            {
                Socket incoming = connection.Accept();
                if (!incoming.Poll(0, SelectMode.SelectRead))
                {
                    continue;
                }
                byte[] buffer = new byte[1024];
                int recieveSize = incoming.Receive(buffer);
                string input = Encoding.ASCII.GetString(buffer, 0, recieveSize);
                string[] splitedInput = input.Split(';');

                if (splitedInput[0] == "mssql")
                {
                    incoming.Send(Encoding.ASCII.GetBytes(/*sqlState.ToString()*/"mssql;connected".ToLower()));
                }
            }
        }

        static void ChangeGameState(ConnectionState sqlState)
        {
            Controller.sqlState = sqlState;
            // dodo event
        }
    }
}
