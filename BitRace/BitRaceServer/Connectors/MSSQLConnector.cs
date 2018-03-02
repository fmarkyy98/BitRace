using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BitRaceServer.QuestionTypes;
using static BitRaceServer.Enums;
using static BitRaceServer.Enums.Difficulty;

namespace BitRaceServer
{
    static class MSSQLConnector
    {
        static string connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
        static SqlConnection sqlConnection= new SqlConnection(connectionString);

        static string ConnectionString
        {
            get { return connectionString; }
        }

        public static void BuildConnection(string serverName, string databaseName, string userName, string password)
        {
            connectionString = $"Data Source={serverName};Initial Catalog={databaseName};User ID={userName};Password={password}";
            sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException)
            {
                throw new InvalidOperationException("SqlException has thrown due to some incorrect parameter.");
            }
        }

        //Dummy
        public static IEnumerable<Player> QueryPlayers() 
        {
            IEnumerable<Player> result;
            result = new List<Player> {
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
                    result.Add(new MainQuestion(i, "Test quetion " + i, QueryAnswers(i)));
                }
            }
            else if (difficulty == normal)
            {
                for (int i = 0; i < limit; i++)
                {
                    result.Add(new PrimaryExtensionQuestion(i, "Test quetion " + i, QueryAnswers(i)));
                }
            }
            else
            {
                for (int i = 0; i < limit; i++)
                {
                    result.Add(new SecondaryExtensionQuestion(i, "Test quetion " + i, QueryAnswers(i)));
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
