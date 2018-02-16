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
        protected Dictionary<char, string> optionalAnswers;
        protected List<char> keysOfSelectedIncorrectAnsver = new List<char>();

        public Question(int id, string text, Dictionary<char, string> optionalAnswers)
        {
            this.id = id;
            this.text = text;
            this.optionalAnswers = new Dictionary<char, string>(optionalAnswers);
            this.keysOfSelectedIncorrectAnsver = new List<char>();
        }

        internal char keyOfCorrectAnsver()
        {
            return (char)0; // todo sql query
        }
    }
}
