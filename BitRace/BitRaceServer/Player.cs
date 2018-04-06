using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static BitRaceServer.Controller;

namespace BitRaceServer
{
    class Player
    {
        int id;
        string name;
        int score;
        int indexOfActualMainQuestion = 0;
        int indexOfPrimaryExtensionQuestion = -1;
        int indexOfSecondaryExtensionQuestion = -1;
        PlayerConnector playerConnector;

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Score { get { return this.score; } set { this.score = value > -1 ? value : 0; } }

        public int IndexOfActualMainQuestion
        {
            get { return indexOfActualMainQuestion; }
            set
            {
                if (value >= Game1.Questions.Count)
                {
                    throw new ArgumentException("Game ended.");
                }
                else
                {
                    indexOfActualMainQuestion = value;
                    Score += Game1.Questions[0].ExtensionQuestions[0].ExtensionQuestions.Count * Game1.Questions[0].ExtensionQuestions.Count -
                        (indexOfPrimaryExtensionQuestion + 1) * Game1.Questions[0].ExtensionQuestions[0].ExtensionQuestions.Count -
                        (indexOfSecondaryExtensionQuestion + 1);
                }

            }
        }

        public int IndexOfPrimaryExtensionQuestion
        {
            get { return indexOfPrimaryExtensionQuestion; }
            set
            {
                if (value >= Game1.Questions[0].ExtensionQuestions.Count)
                {
                    IndexOfActualMainQuestion++;
                    indexOfPrimaryExtensionQuestion = -1;

                }
                else
                {
                    indexOfPrimaryExtensionQuestion = value;
                }
            }
        }

        public int IndexOfSecondaryExtensionQuestion
        {
            get { return indexOfSecondaryExtensionQuestion; }
            set
            {
                if (value >= Game1.Questions[0].ExtensionQuestions[0].ExtensionQuestions.Count)
                {
                    IndexOfPrimaryExtensionQuestion++;
                    indexOfSecondaryExtensionQuestion = -1;
                }
                else
                {
                    indexOfSecondaryExtensionQuestion = value;
                }
            }
        }

        PlayerConnector PlayerConnector { get { return this.playerConnector; } set { this.playerConnector = this.playerConnector ?? value; } }

        public Player(int id, string name, int score = 0)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }

        public Player(int id, string name, Socket socket)
        {
            this.id = id;
            this.name = name;
            playerConnector = new PlayerConnector(socket);
            playerConnector.GetEncestorByReference(this);
        }

        public void Conect(Socket socket)
        {
            playerConnector = playerConnector ?? new PlayerConnector(socket);
            playerConnector.GetEncestorByReference(this);
        }
    }
}