using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BitRaceServer.Enums;

namespace BitRaceServer.QuestionTypes
{
    class SecondaryExtensionQuestion : Question
    {

        public SecondaryExtensionQuestion(int id, string text, Dictionary<char, string> optionalAnswers) : base(id, text, optionalAnswers)
        {
            difficulty = Difficulty.easy;
        }
    }
}
