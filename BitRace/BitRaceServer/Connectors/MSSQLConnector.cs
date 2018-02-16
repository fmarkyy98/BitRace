using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitRaceServer
{
    class MSSQLConnector
    {
        string connectionString;

        string ConnectionString
        {
            get { return connectionString; }
        }

        public MSSQLConnector(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
