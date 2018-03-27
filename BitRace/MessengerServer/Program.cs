using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MessengerServer
{
    class Program
    {
        class MessageRoom {
            List<Socket> connected = new List<Socket>();
            public void Connect(Socket sock) {
                lock (connected)
                {
                    connected.Add(sock);
                }
            }
            public MessageRoom() {
                new Thread(ThreadFunc).Start();
            }
            void ThreadFunc() {
                while (true) {
                    List<Socket> read;
                    List<Socket> error;
                    lock (connected) {
                        read = connected.Where(x => !x.Connected).ToList();
                        read.ForEach(x => connected.Remove(x));
                        if (connected.Count == 0) {
                            Thread.Sleep(1000);
                            continue;
                        }
                        read = connected.ToList();
                        error = connected.ToList();
                    }
                    Socket.Select(read, null, error, 1000);
                    foreach (var s in error) {
                        lock (connected) {
                            connected.Remove(s);
                        }
                    }
                    try
                    {
                        foreach (var rs in read)
                        {
                            byte[] buffer = new byte[1024];
                            int rec = rs.Receive(buffer);
                            foreach (var ss in connected)
                            {
                                if (ss != rs)
                                {
                                    ss.Send(buffer, rec, SocketFlags.None);
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
        }
        static MessageRoom[] rooms = new MessageRoom[] {
            new MessageRoom(),
        };
        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Bind(new IPEndPoint(new IPAddress(new byte[] {127,0,0,1 }), 2345));
            sock.Listen(100);
            int akt = -1;
            while (true) {
                var incoming = sock.Accept();
                rooms[(++akt) % rooms.Length].Connect(incoming);
            }
        }
    }
}
