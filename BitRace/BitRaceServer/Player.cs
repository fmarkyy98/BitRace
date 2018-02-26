using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitRaceServer
{
    class Player
    {
        int id;
        string name;
        int score;

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Score { get { return this.score; } set { this.score = value > -1 ? value : 0; } }

        public Player(int id, string name, int score = 0)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }
    }
}
