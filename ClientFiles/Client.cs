using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace SocketProgrammingBasics
{
    class Client
    {
        // Main Method 
        static void Main(string[] args)
        {
            ExecuteClient();
        }

        // ExecuteClient() Method 
        static void ExecuteClient()
        {
            try
            {
                //Get Server's IP Address
                IPAddress ipAddr = ServerIPAddress.GetServerIPAddress();

                //Get Network Address
                IPEndPoint endPoint = NetworkAddress.GetEndPoint();

                try
                {
                    Console.WriteLine("Client Started!");

                    //Establish connection to Server
                    ConnectionHandler.EstablishConnection();
                    
                    //Send yourAliasToServer
                    UserAlias.SendYourAliasToServer();
                   
                    //Perfrom Chat
                    Messenger.PerformChat(UserAlias.GetYourAlias(), FriendsAlias.GetFriendsAlias());

                    //Close Connection
                    ConnectionHandler.GetSocket().Shutdown(SocketShutdown.Both);
                    ConnectionHandler.GetSocket().Close();
                }

                // Manage of Socket's Exceptions 
                catch (ArgumentNullException ane) {Console.WriteLine("ArgumentNullException : {0}", ane.ToString());}
                catch (SocketException se){Console.WriteLine("SocketException : {0}", se.ToString());}
                catch (Exception e){Console.WriteLine("Unexpected exception : {0}", e.ToString());}
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

