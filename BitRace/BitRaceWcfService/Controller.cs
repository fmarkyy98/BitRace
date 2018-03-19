using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BitRaceWcfService.Enums;
using static BitRaceWcfService.Enums.SQLState;

namespace BitRaceWcfService
{
    class Controller
    {

        static Game game = new Game(10, 3, 3);
        static SQLState sqlState;

        static void Main(string[] args)
        {
            try
            {
                MSSQLConnector.BuildConnection("string", "string", "string", "string");
                sqlState = building;
                Console.WriteLine("Connection was succesfully built.");
                sqlState = succeed;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                sqlState = failed;
            }
            Console.ReadKey();
        }

        static void ChangeGameState(SQLState sqlState)
        {
            Controller.sqlState = sqlState;
            // dodo event
        }
    }
}
