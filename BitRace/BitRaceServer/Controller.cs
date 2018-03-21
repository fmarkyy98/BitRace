using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            try
            {
                MSSQLConnector.BuildConnection("string", "string", "string", "string");
                sqlState = building;
                Console.WriteLine("Connection was succesfully built.");
                sqlState = connected;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                sqlState = disconnected;
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
