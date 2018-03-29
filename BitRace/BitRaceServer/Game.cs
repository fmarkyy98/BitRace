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

        List<Player> players;
        List<MainQuestion> questions;

        public List<MainQuestion> Questions
        {
            get { return new List<MainQuestion>(this.questions); }
        }

        public List<Player> Players
        {
            get { return new List<Player>(this.players); }
        }

        public Game(int countOfMainQuetions, int countOfPrimaryExtensionQuestionsOverMainQuetion, int countOfSecondaryExtensionQuestionsOverPrymaryExtensionQuetion)
        {
            int countOfPrimaryExtensionQuestions;
            int countOfSecondaryExtensionQuestions;
            Dictionary<string, List<Question>> allUseableQuestions = new Dictionary<string, List<Question>>();

            countOfPrimaryExtensionQuestions = countOfMainQuetions * countOfPrimaryExtensionQuestionsOverMainQuetion;
            countOfSecondaryExtensionQuestions = countOfPrimaryExtensionQuestions * countOfSecondaryExtensionQuestionsOverPrymaryExtensionQuetion;

            this.players = QueryPlayers().ToList();
            this.questions = new List<MainQuestion>();

            allUseableQuestions.Add("MainQuetion", QueryQuestions(countOfMainQuetions, hard).ToList());
            allUseableQuestions.Add("PrimaryExtensionQuestion", QueryQuestions(countOfPrimaryExtensionQuestions, normal).ToList());
            allUseableQuestions.Add("SecondaryExtensionQuestion", QueryQuestions(countOfSecondaryExtensionQuestions, easy).ToList());
            questions = new List<MainQuestion>(allUseableQuestions["MainQuetion"].Select(x => (MainQuestion)x).ToList());
            for (int i = 0; i < countOfMainQuetions; i++)
            {
                for (int j = 0; j < countOfPrimaryExtensionQuestionsOverMainQuetion; j++)
                {
                    questions[i].AddQuestion(allUseableQuestions["PrimaryExtensionQuestion"][countOfPrimaryExtensionQuestionsOverMainQuetion * i + j]);
                    for (int k = 0; k < countOfSecondaryExtensionQuestionsOverPrymaryExtensionQuetion; k++)
                    {
                        questions[i].ExtensionQuestions[j].AddQuestion(allUseableQuestions["SecondaryExtensionQuestion"][countOfSecondaryExtensionQuestionsOverPrymaryExtensionQuetion * j + k]);
                    }
                }
            }
        }

        public void AddPlayer(string name)
        {
            Player tempPlayer = new Player(0,name);
            InsertPlayer(tempPlayer);
            players.Add(tempPlayer);
        }

    }
}
