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
        private int Port = 4400;
        IPEndPoint serverAddress;
        Socket clientSocket;

        SocketRequest Request = new SocketRequest();
        JsonSerializer JsonSerializer = new JsonSerializer();

        public void Setup()
        {
            serverAddress = new IPEndPoint(IPAddress.Parse(GetLocalIPAddress()), Port);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(serverAddress);
        }

        public OrderList GetOrdersList()
        {
            //socket connection
            Setup();

            //create request
            Request.action = SocketRequest.ACTION.GET_ORDERS;

            //seriliazing to JSON
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            //send request 
            SendRequestMessage(requestAsJSON);

            //read resultset
            string JsonString = ReadResultset();

            OrderList obj = new OrderList();

            //deseriliasing 
            obj = JsonConvert.DeserializeObject<OrderList>(JsonString);

            clientSocket.Close(); 

            return obj;
        }

        public OrderList GetAssignedOrders()
        {
            Setup();

            Request.action = SocketRequest.ACTION.GET_ASSIGNED_ORDERS;
            string requestAsJSON = JsonConvert.SerializeObject(Request);
            
            SendRequestMessage(requestAsJSON);
            string JsonString = ReadResultset();

            OrderList obj = new OrderList();
            obj = JsonConvert.DeserializeObject<OrderList>(JsonString);

            clientSocket.Close();

            return obj;
        }
        public OrderList GetUnassignedOrders()
        {
            Setup();

            Request.action = SocketRequest.ACTION.GET_UNASSIGNED_ORDERS;
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            SendRequestMessage(requestAsJSON);
            string JsonString = ReadResultset();

            OrderList obj = new OrderList();
            obj = JsonConvert.DeserializeObject<OrderList>(JsonString);

            clientSocket.Close();

            return obj;
        }

        public String ReadResultset()
        {
            byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            string rcv = Encoding.ASCII.GetString(rcvBytes);

            return rcv;

            //missing JSON deserializing
        }

        public void SendRequestMessage(String requestMessage)
        {
            int toSendLen = Encoding.ASCII.GetByteCount(requestMessage);
            byte[] toSendBytes = Encoding.ASCII.GetBytes(requestMessage);
            byte[] toSendLenBytes = BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

    }
}






