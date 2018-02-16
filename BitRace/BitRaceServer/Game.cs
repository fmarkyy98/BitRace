using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitRaceServer.QuestionTypes;

namespace BitRaceServer
{
    class Game
    {
        List<MainQuestion> questions = new List<MainQuestion>();

        List<Player> players = new List<Player>();

        public List<MainQuestion> Questions
        {
            get { return new List<MainQuestion>(questions); }
        }

        public Game()
        {

        }
    }
}
