using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketProgrammingBasics
{
    public class ConnectionHandler
    {
        static Socket socket;
        public static Socket GetSocket()
        {

            // Creation of TCP/IP Socket using Socket Class Costructor

            IPAddress ipAddr = ServerIPAddress.GetServerIPAddress();
            socket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            return socket;
        }
        public static void EstablishConnection()
        {
            socket.Connect(NetworkAddress.GetEndPoint());
        }
    }
}
