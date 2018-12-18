using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Simple_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(IPAddress.Any, 6665);

            server.Start();

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                NetworkStream dataStream = client.GetStream();
                byte[] dataBuffer = new byte[100];

                dataBuffer = Encoding.Default.GetBytes("(ready)");

                dataStream.Write(dataBuffer, 0, dataBuffer.Length);

                while (client.Connected)
                {
                    byte[] messageBuffer = new byte[1024];
                    dataStream.Read(messageBuffer, 0, messageBuffer.Length);
                    Console.WriteLine(Encoding.Default.GetString(messageBuffer));
                }
            }
        }
    }
}
