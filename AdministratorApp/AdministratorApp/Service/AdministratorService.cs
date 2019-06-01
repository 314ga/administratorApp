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

using System.Net;


namespace AdministratorApp.Service
{
    public class AdministratorService : IAdministratorService
    {
        private int Port = 4400;
        IPEndPoint serverAddress;
        Socket clientSocket;

        SocketRequest Request=new SocketRequest();
        JsonSerializer JsonSerializer = new JsonSerializer();

        public AdministratorService()
        {
           
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

        public void Setup()
        {
            serverAddress = new IPEndPoint(IPAddress.Parse(GetLocalIPAddress()), Port);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(serverAddress);
        }

        public string ReadResultset()
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

        public void SendMessage(string Message)
        {
            int toSendLen = Encoding.ASCII.GetByteCount(Message);
            byte[] toSendBytes = Encoding.ASCII.GetBytes(Message);
            byte[] toSendLenBytes = BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
        }

        public OrderList GetOrdersList()
        {

            Setup();
            //create request
            Request.action = SocketRequest.ACTION.GET_ORDERS;

            //seriliazing to JSON
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            //send request 
            SendMessage(requestAsJSON);

            //read resultset
            string JsonString = ReadResultset();

            OrderList obj = new OrderList();
            clientSocket.NoDelay=true;
            //deseriliasing 
            obj = JsonConvert.DeserializeObject<OrderList>(JsonString);

          
            clientSocket.Close();

            return obj;
        }
        public OrderList GetAssignedOrders()
        {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.GET_ASSIGNED_ORDERS;
            string requestAsJSON = JsonConvert.SerializeObject(Request);
            
            SendMessage(requestAsJSON);
            string JsonString = ReadResultset();

            OrderList obj = new OrderList();
            obj = JsonConvert.DeserializeObject<OrderList>(JsonString);

           clientSocket.Close();

            return obj;
        }
        public OrderList GetUnassignedOrders()
        {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.GET_UNASSIGNED_ORDERS;
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            SendMessage(requestAsJSON);
            string JsonString = ReadResultset();

            OrderList obj = new OrderList();
            obj = JsonConvert.DeserializeObject<OrderList>(JsonString);

            clientSocket.Close();

            return obj;
        }
        public ClientList GetClients()
        {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.GET_CLIENTS;
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            SendMessage(requestAsJSON);
            string JsonString = ReadResultset();

            ClientList obj = new ClientList();
            obj = JsonConvert.DeserializeObject<ClientList>(JsonString);
            clientSocket.Close();
            return obj;
        }

        public AbstractClient GetClientById(string Id)
        {
            //socket connection
            Setup();
            AbstractClient client = new AbstractClient();
            client.clientId = Id;
            Request.obj = client;
            Request.action = SocketRequest.ACTION.GET_CLIENT_BY_ID;
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            SendMessage(requestAsJSON);
            string JsonString = ReadResultset();

            client = new AbstractClient();

            client = JsonConvert.DeserializeObject<AbstractClient>(JsonString);

            clientSocket.Close();

            return client;
        }
        public Order GetOrderById(string Id)
        {
            //socket connection
            Setup();
            Order order = new Order();
            order.orderNumber = Id;
            Request.obj = order;
            Request.action = SocketRequest.ACTION.GET_ORDER_BY_ID;
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            SendMessage(requestAsJSON);
            string JsonString = ReadResultset();

        order = new Order();
            order = JsonConvert.DeserializeObject<Order>(JsonString);

            clientSocket.Close();

            return order;
        }
        public ClientList GetContractors()
        {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.GET_CONTRACTORS;
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            SendMessage(requestAsJSON);
            string JsonString = ReadResultset();

            ClientList obj = new ClientList();
            obj = JsonConvert.DeserializeObject<ClientList>(JsonString);
            clientSocket.Close();
            return obj;
        }
        public ClientList GetCustomers()
        {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.GET_CUSTOMERS;
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            SendMessage(requestAsJSON);
            string JsonString = ReadResultset();

            ClientList obj = new ClientList();
            obj = JsonConvert.DeserializeObject<ClientList>(JsonString);
            clientSocket.Close();
            return obj;
        }

        public void UpdateOrder(Order order) {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.UPDATE_ORDER;
            Request.obj = order;
            string orderAsJson = JsonConvert.SerializeObject(Request);
            SendMessage(orderAsJson);
            clientSocket.Close();
        }

        public void DeleteOrder(Order order) {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.DELETE_ORDER;
            Request.obj = order;
            string orderAsJson = JsonConvert.SerializeObject(Request);
            SendMessage(orderAsJson);
            clientSocket.Close();
        }

        public Boolean AddClient(AbstractClient client)
        {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.ADD_CLIENT;
            Request.obj = client;
            string clientAsJson = JsonConvert.SerializeObject(Request);
            SendMessage(clientAsJson);

            string JsonString = ReadResultset();
            Boolean response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            return response;
            
        }

        public Boolean UpdateClient(AbstractClient client)
        {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.UPDATE_CLIENT;
            Request.obj = client;
            string clientAsJson = JsonConvert.SerializeObject(Request);
            SendMessage(clientAsJson);

            string JsonString = ReadResultset();
            Boolean response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            return response;
        }

        public Boolean DeleteClient(AbstractClient client)
        {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.DELETE_CLIENT;
            Request.obj = client;
            string clientAsJson = JsonConvert.SerializeObject(Request);
            SendMessage(clientAsJson);

            string JsonString = ReadResultset();
            Boolean response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            return response;
        }

    }
}






