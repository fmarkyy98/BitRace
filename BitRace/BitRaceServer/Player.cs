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

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Score { get { return score; } set { score = value > -1 ? value : 0; } }

        public Player(int id, string name, int score)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }
    }
}
