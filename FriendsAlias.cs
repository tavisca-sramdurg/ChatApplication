using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgrammingBasics
{
    class FriendsAlias
    {
        public static string friendsAlias;
        public static string GetFriendsAlias()
        {
            //Receive your friend's Alias
            byte[] aliasReceived = new byte[1024];
            int byteAliasReceived = ConnectionHandler.GetSocket()
                                                        .Receive(aliasReceived);
            friendsAlias = Encoding.ASCII.GetString(aliasReceived, 
                                                            0, byteAliasReceived);
            return friendsAlias;
        }
    }
}
