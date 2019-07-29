using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgrammingBasics
{
    class UserAlias
    {
        public static string yourAlias;
        public static void SendYourAliasToServer()
        {
            //Get your Alias
            Console.WriteLine("Enter your Alias: ");
            yourAlias = Console.ReadLine();

            //Send yourAlias
            byte[] sendAlias = Encoding.ASCII.GetBytes(yourAlias);
            int byteAliasSent = ConnectionHandler.GetSocket().Send(sendAlias);
        }

        public static String GetYourAlias()
        {
            return yourAlias;
        }
    }
}
