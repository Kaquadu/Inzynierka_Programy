using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Simple_Server
{
    class Maine
    {
        static void Main(string[] args)
        {
            //Server serv = new Server();
            //serv.Create();
            Client client = new Client();
            client.Create();
            client.Connect();
            client.Loop();
        }
    }

    public class Server
    {
        TcpListener server;
        public Server()
        {
        }

        public void Create()
        {
            server = new TcpListener(IPAddress.Any, 6665);
            server.Start();
            Loop();
        }

        public void Loop()
        {
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

    public class Client
    {
        public byte[] data;
        public string input, stringData;
        public IPEndPoint ipep;
        public Socket server;

        public Client() { }
        public void Create()
        {
            data = new byte[40];
            ipep = new IPEndPoint(IPAddress.Parse("172.31.0.1"), 3333);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect()
        {
            try
            {
                server.Connect(ipep);
                if(server.Connected)
                    Console.WriteLine("Connected");
            }
            catch (SocketException e)
            {
                Console.WriteLine("Unable to connect to server.");
                Console.WriteLine(e.ToString());
            }
        }

        public void Loop()
        {
            input = Console.ReadLine();
            server.Send(Encoding.ASCII.GetBytes(input));

            int recv = server.Receive(data);
            Console.WriteLine(recv);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine(stringData);

            while (true)
            {
                input = Console.ReadLine();
                if (input == "exit")
                    break;
                server.Send(Encoding.ASCII.GetBytes(input));
                data = new byte[40];
                recv = server.Receive(data);
                stringData = Encoding.ASCII.GetString(data, 0, recv);
                Console.WriteLine(stringData);
            }
            Console.WriteLine("Disconnecting from server...");
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }
    }
}
