using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static BitRaceServer.Controller;

namespace BitRaceServer
{
    class PlayerConnector
    {
        Player Encestor;
        Socket connection;
        string input;
        string output;
        bool isRead;
        bool IsRead { get { return isRead; } }

        public string Input
        {
            get
            {
                isRead = true;
                return input;
            }
        }
        public string Output { get { return output; } set { output = value; } }

        public PlayerConnector(Socket socket)
        {
            this.connection = socket;
            new Thread(listener).Start();
        }
        private void listener()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024];
                    int recieveSize = connection.Receive(buffer);
                    string input = Encoding.ASCII.GetString(buffer, 0, recieveSize);
                    string[] splitedInput = input.Split(';');
                    if (input != this.input)
                    {
                        isRead = false;
                        this.input = input;
                        Question actualQuestion = Game1.Questions[Encestor.IndexOfActualMainQuestion];
                        try { actualQuestion = Game1.Questions[Encestor.IndexOfActualMainQuestion].ExtensionQuestions[Encestor.IndexOfPrimaryExtensionQuestion]; }
                        catch (IndexOutOfRangeException) { }
                        try { actualQuestion = Game1.Questions[Encestor.IndexOfActualMainQuestion].ExtensionQuestions[Encestor.IndexOfPrimaryExtensionQuestion].ExtensionQuestions[Encestor.IndexOfSecondaryExtensionQuestion]; }
                        catch (IndexOutOfRangeException) { }
                        if (MSSQLConnector.IsCorrectAnswer(actualQuestion.Id, splitedInput[2]))
                        {
                            if (Encestor.IndexOfPrimaryExtensionQuestion==-1)
                            {
                                Encestor.IndexOfActualMainQuestion++;
                            }
                            else if (Encestor.IndexOfSecondaryExtensionQuestion==-1)
                            {
                                // todo
                            }
                        }
                        else
                        {

                        }
                    }
                }
                catch { }
            }
        }

        public void SendData(string output)
        {
            this.output = output;
            byte[] data = Encoding.ASCII.GetBytes(this.output);
            connection.Send(data);
        }
        public void GetEncestorByReference(Player player)
        {
            this.Encestor = player;
        }
    }
}
