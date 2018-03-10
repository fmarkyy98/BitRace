using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BitRaceServer.Enums;
using static BitRaceServer.Enums.SQLState;

namespace BitRaceServer
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

        #region DiagramGeneratedPropertyes
        internal Game Game
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        internal PlayerConnector PlayerConnector
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal MasterConnector MasterConnector
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
        #endregion
    }
}
