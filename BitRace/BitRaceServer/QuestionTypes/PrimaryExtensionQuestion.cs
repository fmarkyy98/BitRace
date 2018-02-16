using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BitRaceServer.Enums;

namespace BitRaceServer.QuestionTypes
{
    class PrimaryExtensionQuestion : Question
    {
        List<SecondaryExtensionQuestion> extensionQuestions = new List<SecondaryExtensionQuestion>();

        public List<SecondaryExtensionQuestion> ExtensionQuestions
        {
            get { return new List<SecondaryExtensionQuestion>(extensionQuestions); }
        }

        public PrimaryExtensionQuestion(int id, string text, Dictionary<char, string> optionalAnswers, List<SecondaryExtensionQuestion> extensionQuestions) : base(id, text, optionalAnswers)
        {
            this.extensionQuestions = extensionQuestions;
            this.difficulty = Difficulty.normal;
        }
    }
}
