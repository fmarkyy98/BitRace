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
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Bind(new IPEndPoint(new IPAddress(new byte[] { 127, 0, 0, 1 }), 8912));
            sock.Listen(1000);
            Console.WriteLine("Started Listening at LocalHost:8912");

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
                var incoming = sock.Accept();
            }
            Console.ReadKey();
        }

        static void ChangeGameState(ConnectionState sqlState)
        {
            Controller.sqlState = sqlState;
            // dodo event
        }
    }
}
