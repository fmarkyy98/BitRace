using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BitRaceServer
{
    class Player
    {
        int id;
        string name;
        int score;
        int[] actualQuestion = { 0, 0, 0 };
        PlayerConnector playerConnector;

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Score { get { return this.score; } set { this.score = value > -1 ? value : 0; } }
        PlayerConnector PlayerConnector { get { return this.playerConnector; } set { this.playerConnector = this.playerConnector ?? value; } }

        public Player(int id, string name, int score = 0)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }

        public Player(int id, string name,Socket socket)
        {
            this.id = id;
            this.name = name;
            playerConnector = new PlayerConnector(socket);
        }

        public void Conect(Socket socket)
        {
            //if (playerConnector == null)
            //{
            //    playerConnector = new PlayerConnector(socket);
            //}

            playerConnector = playerConnector ?? new PlayerConnector(socket);
        }
    }
}