using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkConnectLib
{
    /// <summary>
    /// This class allows to send and receive bytes in ASCIIEncoding.
    /// 
    /// Created by Andrei Mungiu
    /// </summary>
    public class NetworkConnectionLib
    {
        public NetworkStream NetworkStream { get; set; }
        private IPAddress IpAddress { get; set; }
        private int Port { get; set; }

        public TcpListener TcpListener { get; set; }
        public TcpClient TcpClient { get; set; }
        private static byte[] writeBuffer;
        private static byte[] readBuffer;

        public NetworkConnectionLib(IPAddress localIP, int port)
        {
            IpAddress = localIP;
            Port = port;

            TcpListener = new TcpListener(IpAddress, 4400);
            TcpListener.Start();

            Console.WriteLine("Waiting for someone to connect ...");
            getTCPNetworkStreamAsync();
            Console.WriteLine("Network stream etablished...");

            Task.Run(() => WriteNetworkStreamAsync("Server is Online, this is first test message"));
            Task.Run(() => ReadNetworkStreamAsync());

            Console.WriteLine("TCP listen started...");
        }

        public void getTCPNetworkStreamAsync()
        {
            ///An await expression does not block the thread on which it is executing. 
            ///Instead, it causes the compiler to sign up the rest of the async method 
            ///as a continuation on the awaited task. Control then returns to the caller 
            ///of the async method. When the task completes, it invokes its continuation, 
            ///and execution of the async method resumes where it left off.
            ///
            ///An await expression can occur only in the body of its enclosing method, 
            ///lambda expression, or anonymous method, which must be marked with an async 
            ///modifier.The term await serves as a keyword only in that context. 
            ///Elsewhere, it is interpreted as an identifier.Within the method, lambda 
            ///expression, or anonymous method, an await expression cannot occur in the 
            ///body of a synchronous function, in a query expression, in the block of a 
            ///lock statement, or in an unsafe context.
            ///




            TcpClient = TcpListener.AcceptTcpClient();

           NetworkStream = TcpClient.GetStream();
            Console.WriteLine("TCP connection established and NetworkStream found");
        }

        /// <summary>
        /// Run this method in a separate Task/thread
        /// </summary>
        /// <param name="message"></param>
        /// <returns>a Task</returns>
        public async Task WriteNetworkStreamAsync(string message)
        {
            writeBuffer = new byte[1024];
            writeBuffer = Encoding.ASCII.GetBytes(message);
            await NetworkStream.WriteAsync(writeBuffer, 0, writeBuffer.Length);
        }

        /// <summary>
        /// Read fro network stream and return string with ASCII encoding
        /// </summary>
        /// <returns></returns>
        public async Task<string> ReadNetworkStreamAsync()
        {
            string receivedString = null;

            while (true)
            {
                if (NetworkStream.DataAvailable)
                {
                    readBuffer = new byte[1024];
                    try
                    {
                        int byteCount = await NetworkStream.ReadAsync(readBuffer, 0, readBuffer.Length);
                        receivedString = Encoding.ASCII.GetString(readBuffer, 0, byteCount);
                    }
                    catch (IOException e) { break; }
                }
            }

            return receivedString;
        }
    }
}