using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerConnectLib
{
    class TcpClientLib
    {
        public NetworkStream NetworkStream { get; set; }
        TcpClient client;
        byte[] readBuffer = new byte[1024];
        string stringData;
        private static byte[] writeBuffer;

        public TcpClientLib(string serverIp, int port)
        {
            try
            {
                client = new TcpClient(serverIp, port);
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.ToString());
                return;
            }

            /// NOTE: We do not need to use "TcpClient client = newsock.AcceptTcpClient();"
            /// as we do on on the server
            NetworkStream = client.GetStream();
            Console.WriteLine("Connected to server");
            Console.WriteLine("Type a message: ");

            // TODO
            Task.Run(() => ReadNetworkStreamAsync());
        }

        public async Task ReadNetworkStreamAsync()
        {
            while (true)
            {
                if (NetworkStream.DataAvailable)
                {
                    readBuffer = new byte[1024];
                    try
                    {
                        int recv = await NetworkStream.ReadAsync(readBuffer, 0, readBuffer.Length);
                        stringData = Encoding.ASCII.GetString(readBuffer, 0, recv);
                    }
                    catch (IOException e) { break; }
                }
            }
        }

        public async void WriteNetworkStreamAsync(string message)
        {
            writeBuffer = new byte[1024];
            writeBuffer = Encoding.ASCII.GetBytes(message);
            await NetworkStream.WriteAsync(writeBuffer, 0, writeBuffer.Length);

            //await NetworkStream.WriteAsync(Encoding.ASCII.GetBytes(message), 0, message.Length);
            NetworkStream.Flush();
        }
    }
}
