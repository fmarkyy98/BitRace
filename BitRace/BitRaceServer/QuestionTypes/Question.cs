using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BitRaceServer.Enums;

namespace BitRaceServer
{
    abstract class Question
    {
        protected int id;
        protected string text;
        protected Difficulty difficulty;
        protected Dictionary<string, string> optionalAnswers;
        protected List<int> keysOfSelectedIncorrectAnsver = new List<int>();

        public int Id { get { return id; } }

        public Question(int id, string text, Dictionary<string, string> optionalAnswers)
        {
            this.id = id;
            this.text = text;
            this.optionalAnswers = new Dictionary<string, string>(optionalAnswers);
            this.keysOfSelectedIncorrectAnsver = new List<int>();
        }

        internal string CaracterOfCorrectAnsver()
        {
            foreach (KeyValuePair<string, string> answer in optionalAnswers)
            {
               if( MSSQLConnector.IsCorrectAnswer(this.id, answer.Key))
                {
                    return answer.Key;
                }
            }
            throw new MissingFieldException("This question doesn't bind to any correct ansver.");
        }
        #region DiagramGeneratedPropertyes
        internal Enums Difficcilty
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
