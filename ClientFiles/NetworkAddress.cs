using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace SocketProgrammingBasics
{
    class NetworkAddress
    {
        public static IPEndPoint GetEndPoint()
        {
            IPAddress ipAddr = ServerIPAddress.GetServerIPAddress();
            IPEndPoint endPoint = new IPEndPoint(ipAddr, 11111);
            return endPoint;
        }
    }
}
