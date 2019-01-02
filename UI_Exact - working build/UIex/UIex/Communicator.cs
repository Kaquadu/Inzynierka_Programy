using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Numerics;

namespace UIex
{
    public class Communicator
    {
        public Communicator() { }

        public RobotClient robotClient;
        public DistanceMeter distanceMeter;

        public List<Vector3> toolPositions;

        public bool CreateRobotClient(string Address, int port)
        {
            robotClient = new RobotClient();
            robotClient.Create(Address, port);
            return robotClient.Connect();
        }

        public void ToolPositionsSet()
        {
            toolPositions = new List<Vector3>();
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

        public string KindaDunnoWhatIAmDoing()
        {
            if (robotClient.ReceiveMessage())
                return RemoveWhiteSpaces(robotClient.stringData);
            else return "Cannoc reveive message, exception: " + robotClient.excpt;
        }

        public string ReceiveMessageFromRobot()
        {
            if(robotClient.ReceiveMessage())
            {
                if (RemoveWhiteSpaces(robotClient.stringData) == "(Stop)")
                    return RemoveWhiteSpaces(robotClient.stringData);
                else if (RemoveWhiteSpaces(robotClient.stringData) == "(Ready)")
                {
                    try
                    {
                        robotClient.SendMessage("(Point)");
                            Console.WriteLine("GIMME POINTS");
                        if (robotClient.ReceiveMessage())
                        {
                            string[] points = RemoveWhiteSpaces(robotClient.stringData).Split('/');
                            for (int i = 0; i < points.Length; i++)
                            {
                                points[i] = points[i].Replace('.', ',');
                                Console.WriteLine(points[i]);
                            }
                            toolPositions.Add(new Vector3(float.Parse(points[0]), float.Parse(points[1]), float.Parse(points[2])));
                            return "(Points)";
                        }
                        else return "(FPoints)";
                    }
                    catch (Exception exc)
                    {
                        return "Exception in (Ready): \n" + exc.ToString();
                    }
                }
                else if (RemoveWhiteSpaces(robotClient.stringData) == "(Failed)")
                    return RemoveWhiteSpaces(robotClient.stringData) + "- cannot set arm power";
                else return "Command not recognized";
            }
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
            for (int i = 0; i < 40; i++)
            {
                if (message[i] != 0)
                    wowhites += message[i];
            }

            return wowhites;
        }
    }
}