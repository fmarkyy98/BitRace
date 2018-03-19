using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BitRaceWcfService.Enums;

namespace BitRaceWcfService.QuestionTypes
{
    class SecondaryExtensionQuestion : Question
    {

        public SecondaryExtensionQuestion(int id, string text, Dictionary<int, string> optionalAnswers) : base(id, text, optionalAnswers)
        {
            this.difficulty = Difficulty.easy;
        }
    }
}
