using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UIex
{
    public class Communicator
    {
        public Communicator() { }

        public RobotClient robotClient;
        public DistanceMeter distanceMeter;


        public bool CreateRobotClient(string Address, int port)
        {
            robotClient = new RobotClient();
            robotClient.Create(Address, port);
            return robotClient.Connect();
        }

        public bool CreateDistanceMeter (string portName, string baudRate)
        {
            Console.WriteLine(portName + "  " + baudRate);
            distanceMeter = new DistanceMeter();
            return distanceMeter.PreparePort(portName, baudRate);
        }

        public bool SendMessageToRobot(string message)
        {
            return robotClient.SendMessage(message);
        }

        public string ReceiveMessageFromRobot()
        {
            if (robotClient.ReceiveMessage())
                return RemoveWhiteSpaces(robotClient.stringData);
            else return "Cannoc reveive message, exception: " + robotClient.excpt;
        }

        public bool CommitAScan(string path)
        {
            if (!distanceMeter.MakeScan())
                return false;
            else
            {
                return distanceMeter.ExportDistancesToTxt(path);
            }
        }

        public void DisconnectRobot()
        {
            robotClient.Disconnect();
        }
        public void DisconnectScanner()
        {
            distanceMeter.CloseConnection();
        }

        public bool CheckRobotConnection()
        {
            return robotClient.CheckConnection();
        }

        public string RemoveWhiteSpaces(string message)
        {
            string wowhites = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] != 0)
                    wowhites += message[i];
            }

            return wowhites;
        }
    }
}