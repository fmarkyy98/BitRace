using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitRaceServer.QuestionTypes;
using static BitRaceServer.Enums;
using static BitRaceServer.Enums.Difficulty;

namespace BitRaceServer
{
    class Game
    {
        List<Player> players;
        List<MainQuestion> questions;
        MSSQLConnector mssqlConnector = new MSSQLConnector("");
        Dictionary<string, List<Question>> allQuestions = new Dictionary<string, List<Question>>();
        
        public List<MainQuestion> Questions
        {
            get { return new List<MainQuestion>(this.questions); }
        }

        public List<Player> Players
        {
            get { return new List<Player>(this.players); }
        }

        public Game(int countOfMainQuetions, int countOfExtensionQuestionsPerMainQuetion, int countOfExtensionQuestionsPerPrymaryExtensionQuetion)
        {
            this.questions = new List<MainQuestion>();
            this.players = mssqlConnector.QueryPlayers().ToList();
            allQuestions.Add("MainQuetion", mssqlConnector.QueryQuestions(countOfMainQuetions, hard).ToList());
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
