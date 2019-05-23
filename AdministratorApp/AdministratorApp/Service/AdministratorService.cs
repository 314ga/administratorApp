using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AdministratorApp.Model;
using Newtonsoft.Json;
using ServerConnectLib;
using System.Net;


namespace AdministratorApp.Service
{
    public class AdministratorService
    {
        private int port = 4400;
        IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse("192.168.1.145"), 4400);

        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        SocketRequest request = new SocketRequest();
        JsonSerializer jsonSerializer = new JsonSerializer();


        public void GetOrdersList()
        {
            clientSocket.Connect(serverAddress);

            
            request.action = SocketRequest.ACTION.GET_ORDERS;

            
            string requestAsJSON = JsonConvert.SerializeObject(request);

            // Sending
            int toSendLen = Encoding.ASCII.GetByteCount(requestAsJSON);
            byte[] toSendBytes = Encoding.ASCII.GetBytes(requestAsJSON);
            byte[] toSendLenBytes = BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);


            /*
            // Receiving
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            string rcv = Encoding.ASCII.GetString(rcvBytes);

            Console.WriteLine("Client received: " + rcv);
            Console.ReadLine();*/

            

        }
    }
}






