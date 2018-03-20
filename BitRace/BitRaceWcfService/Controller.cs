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
                Controller.sqlState = building;
                Console.WriteLine("Connection was succesfully built.");
                Controller.sqlState = connected;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                Controller.sqlState = disconected;
            }
            Console.ReadKey();
        } 
    }
}
