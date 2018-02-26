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
     static class MSSQLConnector
    {
        static string connectionString;

        static string ConnectionString
        {
            get { return connectionString; }
        }

        //public MSSQLConnector(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}

        public static IEnumerable<Player> QueryPlayers() //Dummy
        {
            IEnumerable<Player> result;
            result = new Player[] {
                new Player(0, "Team0"),
                new Player(1, "Team1"),
                new Player(2, "Team2")
            };
            return result;
        }

        public static IEnumerable<Question> QueryQuestions(int limit, Difficulty difficulty) //Dummy
        {
            List<Question> result = new List<Question>();
            if (difficulty == hard)
            {
                for (int i = 0; i < limit; i++)
                {
                    result.Add(new MainQuestion(i, "Test quetion 1",QueryAnswers(i), null));
                }
            }
            else if (difficulty == normal)
            {
                for (int i = 0; i < limit; i++)
                {
                    result.Add(new PrimaryExtensionQuestion(i, "Test quetion 1", QueryAnswers(i), null));
                }
            }
            else
            {
                for (int i = 0; i < limit; i++)
                {
                    result.Add(new SecondaryExtensionQuestion(i, "Test quetion 1", QueryAnswers(i)));
                }
            }
            return result;
        }

        public static Dictionary<int, string> QueryAnswers(int questinId) //Dummy
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            for (int i = 0; i < 4; i++)
            {
                result.Add(i, "Válasz:" + i);
            }
            return result;
        }

        public static bool IsCorrectAnswer(int questionId, int anvwerId) //Dummy
        {
            return false;
        }

    }
}
