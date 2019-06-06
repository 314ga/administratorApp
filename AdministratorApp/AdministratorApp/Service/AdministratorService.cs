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
    /// <summary>
    /// The class that holds all business logic for administrator application
    /// Contains all methods for all possible requests that can be send to java server
    /// </summary>
    /// <remarks>
    /// creates socket connection, requests for the java server, receiving request from java server
    /// </remarks>
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

        /// <summary>
        /// This method is getting local addres from the client computer
        /// </summary>
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

        /// <summary>
        /// This method creates socket connection on chosen port(in our case 4400)
        /// </summary>
        public void Setup()
        {
            serverAddress = new IPEndPoint(IPAddress.Parse(GetLocalIPAddress()), Port);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(serverAddress);
        }

        /// <summary>
        /// This method is converting ASCII bytes to string
        /// </summary>
        public string ReadResultset()
        {
             byte[] rcvLenBytes = new byte[4];
            clientSocket.Receive(rcvLenBytes);
            int rcvLen = BitConverter.ToInt32(rcvLenBytes, 0);
            byte[] rcvBytes = new byte[rcvLen];
            clientSocket.Receive(rcvBytes);
            string rcv = Encoding.ASCII.GetString(rcvBytes);

            return rcv;
        }

        /// <summary>
        /// This method is sending ASCII bytes with the header byte giving the length of the message
        /// </summary>
        public void SendMessage(string Message)
        {
            int toSendLen = Encoding.ASCII.GetByteCount(Message);
            byte[] toSendBytes = Encoding.ASCII.GetBytes(Message);
            byte[] toSendLenBytes = BitConverter.GetBytes(toSendLen);
            clientSocket.Send(toSendLenBytes);
            clientSocket.Send(toSendBytes);
        }
        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns ClientList
        /// with all orders ordered by order ID
        /// </summary>
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
        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns ClientList
        /// with all assigned orders
        /// </summary>
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
        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns OrderList
        /// with all unassigned orders
        /// </summary>
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
        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns ClientList
        /// with all clients
        /// </summary>
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
        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns AbstractClient
        /// object based on provided ID of the client
        /// </summary>
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
        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns Order
        /// object based on provided ID of the order
        /// </summary>
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
        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns ClientList
        /// with all contractors
        /// </summary>
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
        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns ClientList
        /// with all customers
        /// </summary>
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
        /// <summary>
        /// sets UPDATE_ORDER action, send it to java server and waiting for response if request was succesfully executed
        /// </summary>
        public Boolean UpdateOrder(Order order) {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.UPDATE_ORDER;
            Request.obj = order;
            string orderAsJson = JsonConvert.SerializeObject(Request);
            SendMessage(orderAsJson);

            string JsonString = ReadResultset();
            Boolean response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            return response;
        }
        /// <summary>
        /// sets DELETE_ORDER action, send it to java server and waiting for response if request was succesfully executed
        /// </summary>
        public Boolean DeleteOrder(Order order) {
            //socket connection
            Setup();

            Request.action = SocketRequest.ACTION.DELETE_ORDER;
            Request.obj = order;
            string orderAsJson = JsonConvert.SerializeObject(Request);
            SendMessage(orderAsJson);

            string JsonString = ReadResultset();
            Boolean response = false;
            if (JsonString.Equals("success")) { response = true; }
            clientSocket.Close();
            return response;
        }
        /// <summary>
        /// sets ADD_CLIENT action, send it to java server and waiting for response if request was succesfully executed
        /// </summary>
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

        /// <summary>
        /// sets UPDATE_CLIENT action, send it to java server and waiting for response if request was succesfully executed
        /// </summary>
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

        /// <summary>
        /// sets DELETE_CLIENT action, send it to java server and waiting for response if request was succesfully executed
        /// </summary>
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

        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns OrderList
        /// with orders ordered by status
        /// </summary>
        public OrderList GetOrdersByStatus()
        {
            Setup();
            //create request
            Request.action = SocketRequest.ACTION.GET_ORDERS_GROUPBY_STATUS;

            //seriliazing to JSON
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            //send request 
            SendMessage(requestAsJSON);

            //read resultset
            string JsonString = ReadResultset();

            OrderList obj = new OrderList();
            clientSocket.NoDelay = true;
            //deseriliasing 
            obj = JsonConvert.DeserializeObject<OrderList>(JsonString);


            clientSocket.Close();

            return obj;
        }


        /// <summary>
        /// sets action, send it to java server and receive object, deserialize it, returns OrderList
        /// with orders ordered by deadline
        /// </summary>
        public OrderList GetAllOrdersOrderByDeadline()
        {
            Setup();
            //create request
            Request.action = SocketRequest.ACTION.GET_ORDERS_GROUPBY_DEADLINE;

            //seriliazing to JSON
            string requestAsJSON = JsonConvert.SerializeObject(Request);

            //send request 
            SendMessage(requestAsJSON);

            //read resultset
            string JsonString = ReadResultset();

            OrderList obj = new OrderList();
            clientSocket.NoDelay = true;
            //deseriliasing 
            obj = JsonConvert.DeserializeObject<OrderList>(JsonString);


            clientSocket.Close();

            return obj;
        }
    }
}






