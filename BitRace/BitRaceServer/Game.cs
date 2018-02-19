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
        List<MainQuestion> questions;
        List<Player> players;

        public List<MainQuestion> Questions
        {
            get { return new List<MainQuestion>(this.questions); }
        }

        public List<Player> Players
        {
            get { return new List<Player>(this.players); }
        }

        public Game(List<MainQuestion> questions, List<Player> players)
        {
            this.questions = new List<MainQuestion>(questions);
            this.players = new List<Player>(players);
        }
        #region DiagramGeneratedPropertyes
        internal PrimaryExtensionQuestion PrimaryExtensionQuestion
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal SecondaryExtensionQuestion SecondaryExtensionQuestion
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal Player Player
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
