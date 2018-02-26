using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitRaceServer.QuestionTypes;
using static BitRaceServer.MSSQLConnector;
using static BitRaceServer.Enums;
using static BitRaceServer.Enums.Difficulty;

namespace BitRaceServer
{
    class Game
    {
        int countOfMainQuetions;
        int countOfPrimaryExtensionQuestions;
        int countOfSecondaryExtensionQuestions;
        List<Player> players;
        List<MainQuestion> questions;
        Dictionary<string, List<Question>> allUseableQuestions = new Dictionary<string, List<Question>>();
        
        public List<MainQuestion> Questions
        {
            get { return new List<MainQuestion>(this.questions); }
        }

        public List<Player> Players
        {
            get { return new List<Player>(this.players); }
        }

        public Game(int countOfMainQuetions, int countOfPrimaryExtensionQuestionsPerMainQuetion, int countOfSecondaryExtensionQuestionsPerPrymaryExtensionQuetion)
        {
            this.countOfMainQuetions = countOfMainQuetions;
            this.countOfPrimaryExtensionQuestions = this.countOfMainQuetions * countOfPrimaryExtensionQuestionsPerMainQuetion;
            this.countOfSecondaryExtensionQuestions = this.countOfPrimaryExtensionQuestions * countOfSecondaryExtensionQuestionsPerPrymaryExtensionQuetion;
            this.questions = new List<MainQuestion>();
            this.players = QueryPlayers().ToList();
            this.allUseableQuestions.Add("MainQuetion", QueryQuestions(countOfMainQuetions, hard).ToList());
            this.allUseableQuestions.Add("PrimaryExtensionQuestion", QueryQuestions(countOfPrimaryExtensionQuestions, normal).ToList());
            this.allUseableQuestions.Add("SecondaryExtensionQuestion", QueryQuestions(countOfSecondaryExtensionQuestions, easy).ToList());
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
