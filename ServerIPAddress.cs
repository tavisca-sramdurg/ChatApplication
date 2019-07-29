using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketProgrammingBasics
{
    class ServerIPAddress
    {
        public static IPAddress GetServerIPAddress()
        {
            IPAddress ipAddr = IPAddress.Parse("172.16.5.214");
            return ipAddr;
        }
    }
}
