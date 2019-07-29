using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgrammingBasics
{
    class Messenger
    {
        public static void PerformChat(String yourAlias, String friendsAlias)
        {
            Console.WriteLine("Shravan's (Client) socket connected to -> {0} ({1}) ",
                friendsAlias, 
                ConnectionHandler.GetSocket().RemoteEndPoint.ToString());
            //begin chat
            while (true)
            {
                //Get message that client sends to server 
                Console.WriteLine("{0}: ", yourAlias);
                string getMessage = Console.ReadLine();
                byte[] messageSent = Encoding.ASCII.GetBytes(getMessage);

                //Actually send the message
                int byteSent = ConnectionHandler.GetSocket().Send(messageSent);

                //Receive the message
                byte[] messageReceived = new byte[1024];
                int byteRecv = ConnectionHandler.GetSocket().Receive(messageReceived);
                Console.WriteLine("{0}: {1}", friendsAlias, Encoding.ASCII.GetString(messageReceived, 0, byteRecv));

                //Check if Server wants to End the chat 
                if (Encoding.ASCII.GetString(messageReceived, 0, byteRecv).ToLowerInvariant() == "quit")
                {
                    Console.WriteLine("Ending Chat Session!");
                    break;
                }
            }
            //chat ends
        }
    }
}
