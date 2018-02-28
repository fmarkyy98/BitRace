using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BitRaceServer.Enums;

namespace BitRaceServer.QuestionTypes
{
    class MainQuestion : Question, IExtendable
    {
        List<PrimaryExtensionQuestion> extensionQuestions = new List<PrimaryExtensionQuestion>();

        public List<PrimaryExtensionQuestion> ExtensionQuestions
        {
            get { return new List<PrimaryExtensionQuestion>(extensionQuestions); }
        }

        public MainQuestion(int id, string text, Dictionary<int, string> optionalAnswers) : base(id, text, optionalAnswers)
        {
            this.difficulty = Difficulty.hard;
        }

        public MainQuestion(int id, string text, Dictionary<int, string> optionalAnswers, List<PrimaryExtensionQuestion> extensionQuestions) : base(id, text, optionalAnswers)
        {
            this.extensionQuestions = extensionQuestions;
            this.difficulty = Difficulty.hard;
        }

        public void AddQuestion(Question question)
        {
            this.extensionQuestions.Add((PrimaryExtensionQuestion)question);
        }

    }
}
