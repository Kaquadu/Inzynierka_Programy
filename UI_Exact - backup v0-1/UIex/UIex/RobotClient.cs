using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace UIex
{
    public class RobotClient
    {
        public byte[] data;
        public string input, stringData;
        public IPEndPoint ipep;
        public Socket server;
        public string excpt;

        public RobotClient() { }
        public bool Create(string Address, int port)
        {
            try
            {
                data = new byte[40];
                ipep = new IPEndPoint(IPAddress.Parse(Address), port);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                return true;
            }
            catch (Exception ex)
            {
                excpt = ex.ToString();
                return false;
            }
        }

        public bool Connect()
        {
            try
            {
                IAsyncResult result = server.BeginConnect(ipep, null, null);

                bool success = result.AsyncWaitHandle.WaitOne(5000, true);

                if (server.Connected)
                {
                    return true;
                }
                else
                {
                    throw new ApplicationException("Failed to connect server.");
                }

            }
            catch (Exception e)
            {
                excpt = e.ToString();
                return false;
            }
        }

        public bool SendMessage(string message)
        {
            try
            {
                input = message;
                server.Send(Encoding.ASCII.GetBytes(input));
                return true;
            }
            catch (Exception ex)
            {
                excpt = ex.ToString();
                return false;
            }
        }

        public bool ReceiveMessage()
        {
            try
            {
                
                int recv = server.Receive(data);
                stringData = Encoding.ASCII.GetString(data, 0, recv);
                return true;
            }
            catch (Exception ex)
            {
                excpt = ex.ToString();
                return false;
            }
        }

        public bool CheckConnection()
        {
            Ping x = new Ping();
            PingReply reply = x.Send(ipep.Address);

            if (reply.Status == IPStatus.Success)
                return true;
            else return false;
        }

        public void Disconnect()
        {
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }
    }
}