using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BitRacePlayer.Enums;
using static BitRacePlayer.Enums.ConnectionState;
using static BitRacePlayer.Enums.ConnectionType;

namespace BitRacePlayer
{
    static class Enums
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

        public static ConnectionState ToConnectionState(string s)
        {
            return s == "disconnected" ? disconnected : s == "building" ? building : connected;
        }

        public static ConnectionType ToConnectionType(string s)
        {
            return s == "mssql" ? MSSQL : TCPIP;
        }
    }
}
