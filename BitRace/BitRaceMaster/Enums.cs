using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitRaceMaster
{
    class Enums
    {
        public enum ConnectionState
        {
            disconnected,
            building,
            connected
        }

        public enum ConnectionType
        {
            MSSQL,
            TCPIP
        }
    }
}
