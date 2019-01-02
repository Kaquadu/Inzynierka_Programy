using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Numerics;
using System.Collections;
using System.Globalization;
using OpenTK;

namespace UIex
{
    public partial class Form1 : Form
    {
        public static Communicator communicator;

        public static bool isScannerConnected = false;
        public static bool isRobotConnected = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public int clickCounts = 0;

        public Form1()
        {
            InitializeComponent();
            communicator = new Communicator();

            backgroundWorker__automatedScan.WorkerReportsProgress = true;
            backgroundWorker__automatedScan.WorkerSupportsCancellation = true;

            panel__Communication.Visible = true;
            panel__Export.Visible = false;
            panel__Scanning.Visible = false;

            checkBox__ManualScanning.CheckState = CheckState.Checked;
            checkBox__AutomatedScanning.CheckState = CheckState.Unchecked;
            button__StartStopAutomatedScanning.Enabled = false;
        }



        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }



        private void pictureBox5_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox__Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox__Communication_Click(object sender, EventArgs e)
        {
            panel__Communication.Visible = true;
            panel__Export.Visible = false;
            panel__Scanning.Visible = false;
            //Console.WriteLine("Com: " + panel__Communication.Visible + ", Exp: " + panel__Export.Visible + ", Scan: " + panel__Scanning.Visible);
        }

        private void pictureBox__Scanning_Click(object sender, EventArgs e)
        {
            panel__Scanning.Visible = true;
            panel__Communication.Visible = false;
            panel__Export.Visible = false;
            //Console.WriteLine("Com: " + panel__Communication.Visible + ", Exp: " + panel__Export.Visible + ", Scan: " + panel__Scanning.Visible);
        }

        private void pictureBox__Export_Click(object sender, EventArgs e)
        {
            panel__Export.Visible = true;
            panel__Scanning.Visible = false;
            panel__Communication.Visible = false;
            //Console.WriteLine("Com: " + panel__Communication.Visible + ", Exp: " + panel__Export.Visible + ", Scan: " + panel__Scanning.Visible);
        }

        private void button__ConnectScanner_Click(object sender, EventArgs e)
        {

            try
            {
                if (communicator.CreateDistanceMeter(textBox__COM.Text, textBox__BaudRate.Text))
                {
                    isScannerConnected = true;
                    label__CheckScanner.Text = "Connected";
                    label__CheckScanner.ForeColor = Color.Green;
                    OutputLogWrite("Scanner sconnected");
                }
                else
                {
                    isScannerConnected = false;
                    label__CheckScanner.Text = "Disconnected";
                    label__CheckScanner.ForeColor = Color.Red;
                    OutputLogWrite("Scanner not sconnected");
                    OutputLogWrite(communicator.distanceMeter.excpt);
                }
            }
            catch (Exception exc)
            {
                OutputLogWrite(exc.ToString());
            }
        }

        private void button__ConnectRobot_Click(object sender, EventArgs e)
        {
            try
            {
                if (communicator.CreateRobotClient(textBox__RobotIP.Text, Int32.Parse(textBox__RobotPort.Text)))
                {
                    SetRobotConnection(true);
                }
                else
                {
                    SetRobotConnection(false);
                }
            }
            catch (Exception exc)
            {
                OutputLogWrite(exc.ToString());
            }
        }

        private void checkBox__ManualScanning_CheckedChanged(object sender, EventArgs e)
        {
            checkBox__AutomatedScanning.CheckState = CheckState.Unchecked;
            button__StartStopAutomatedScanning.Enabled = false;
            button__MakeScan.Enabled = true;
            button__MoveRobot.Enabled = true;
            button__MoveToHome.Enabled = true;
        }

        private void checkBox__AutomatedScanning_CheckedChanged(object sender, EventArgs e)
        {
            checkBox__ManualScanning.CheckState = CheckState.Unchecked;
            button__StartStopAutomatedScanning.Enabled = true;
            button__MakeScan.Enabled = false;
            button__MoveRobot.Enabled = false;
            button__MoveToHome.Enabled = false;
        }

        private void button__MoveToHome_Click(object sender, EventArgs e)
        {
            if (communicator.CheckRobotConnection())
            {
                communicator.ToolPositionsSet();
                try
                {
                    communicator.SendMessageToRobot("(Start)");
                    OutputLogWrite("Succesfuly sent (Start) to server");    
                }
                catch (Exception exc)
                {
                    OutputLogWrite(exc.ToString());
                }
                string msg = communicator.ReceiveMessageFromRobot();
                OutputLogWrite("Message from robot: " + msg);
            }
        }

        private void button__MoveRobot_Click(object sender, EventArgs e)
        {
            //clickCounts++;
            if (communicator.CheckRobotConnection())
            {
                try
                {
                    communicator.SendMessageToRobot("(Ready)");
                    OutputLogWrite("Succesfuly sent (Ready) to server");
                }
                catch (Exception exc)
                {
                    OutputLogWrite(exc.ToString());
                }

                string msg = communicator.ReceiveMessageFromRobot();
                OutputLogWrite("Message from robot: " + msg);
            }
            else
            {
                OutputLogWrite("Robot lost connection");
            }

            //OutputLogWrite("Clicks per click:" + clickCounts);
            //clickCounts = 0;
        }

        private void button__MakeScan_Click(object sender, EventArgs e)
        {
            if (isScannerConnected)
            {
                try
                {
                    if(communicator.CommitAScan(textBox__ScanResultsFile.Text))
                        OutputLogWrite("Succesfuly commited a scan");
                    else OutputLogWrite("Scan unsuccesful"); //OutputLogWrite(communicator.distanceMeter.excpt);
                }
                catch (Exception exc)
                {
                    OutputLogWrite(exc.ToString());
                }
            }
        }

        private void button__StartStopAutomatedScanning_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox__ScanResultsFile.Text, false);
            sw.Close();
            communicator.ToolPositionsSet();
            try
                {
                if (button__StartStopAutomatedScanning.Text == "Start Scanning" && backgroundWorker__automatedScan.IsBusy != true)
                    {
                        button__StartStopAutomatedScanning.Text = "Stop Scanning";
                        button__ScanAccuracy.Enabled = false;
                        backgroundWorker__automatedScan.RunWorkerAsync();
                    }
                    else if (button__StartStopAutomatedScanning.Text == "Stop Scanning")
                    {
                        button__StartStopAutomatedScanning.Text = "Start Scanning";
                        button__ScanAccuracy.Enabled = true;
                        backgroundWorker__automatedScan.CancelAsync();
                    }
                }
                catch (Exception exc)
                {
                    OutputLogWrite(exc.ToString());
                }
        }

        public void AutomatedScan()
        {
            if (communicator.CheckRobotConnection() && isScannerConnected)
            {
                try
                {
                    if (communicator.SendMessageToRobot("(Start)"))
                        OutputLogWrite("Sending (Start) succesful");
                    else OutputLogWrite("Sending (Start) unsuccesful");

                    string msg = communicator.ReceiveMessageFromRobot();

                    //OutputLogWrite("Message before removing spaces: " + msg);
                    OutputLogWrite(msg);

                    if (msg == "(Points)")
                    {
                        communicator.CommitAScan(textBox__ScanResultsFile.Text);
                        OutputLogWrite("Commited a scan");
                    }
                    else OutputLogWrite("Robot sent: " + msg);

                    communicator.SendMessageToRobot("(Ready)");

                    while (msg != "(Stop)")
                    {
                        msg = "";
                        msg = communicator.ReceiveMessageFromRobot();

                        if (msg == "(Points)")
                        {
                            if (communicator.CommitAScan(textBox__ScanResultsFile.Text))
                                OutputLogWrite("Scan commited succesfuly");
                            else OutputLogWrite("Scan unsuccesful");
                            communicator.SendMessageToRobot("(Ready)");
                            OutputLogWrite("Receive (Ready) succesful");
                        }
                        else if (msg == "(Stop)") OutputLogWrite("(Stop) received");
                        else OutputLogWrite("Receive (Ready) or (Stop) unsuccesful");
                    }

                    button__StartStopAutomatedScanning.Text = "Start Scanning";
                    button__ScanAccuracy.Enabled = true;
                    Console.WriteLine(communicator.toolPositions.Count());

                }
                catch (Exception exc)
                {
                    OutputLogWrite(exc.ToString());
                }
            }
        }

        private void button__ScanAccuracy_Click(object sender, EventArgs e)
        {
            if (communicator.CheckRobotConnection() && isRobotConnected)
            {
                try
                {
                    if (communicator.SendMessageToRobot("(Accu)"))
                        OutputLogWrite("Succesfuly sent (Accu) to robot");
                    else OutputLogWrite("Can't send message to robot, exception: \n" + communicator.robotClient.excpt);

                    string msg = communicator.ReceiveMessageFromRobot();
                    Console.WriteLine(msg);

                    if (msg == "(Ready)")
                    {
                        Console.WriteLine("Succesfuly received (Ready) from robot");
                        if (communicator.SendMessageToRobot("+" + textBox__ScanAccuracy.Text + " end"))
                            OutputLogWrite("Succesfuly sent " + "+" + textBox__ScanAccuracy.Text + " end" + " to robot");
                        else OutputLogWrite("Can't send message to robot, exception: \n" + communicator.robotClient.excpt);
                    }
                    else OutputLogWrite("Robot sent: " + msg);
                }
                catch (Exception exc)
                {
                    OutputLogWrite(exc.ToString());
                }
            }
        }

        private void button__DisconnectScanner_Click(object sender, EventArgs e)
        {
            try
            {
                communicator.DisconnectScanner();
                label__CheckScanner.Text = "Disconnected";
                label__CheckScanner.ForeColor = Color.Red;
                OutputLogWrite("Scanner disconnected");
            }
            catch (Exception exc)
            {
                OutputLogWrite(exc.ToString());
            }
        }

        private void button__DisconnectRobot_Click(object sender, EventArgs e)
        {
            try
            {
                communicator.DisconnectRobot();
                label__CheckRobot.Text = "Disconnected";
                label__CheckRobot.ForeColor = Color.Red;
                OutputLogWrite("Robot disconnected");
            }
            catch (Exception exc)
            {
                OutputLogWrite(exc.ToString());
            }
        }

        private void button__XYZExport_Click(object sender, EventArgs e)
        {
            try
            {
                ParserXYZ parser = new ParserXYZ();

                OutputLogWrite("Started parsing distances to XYZ");

                List<string> string_lenghts = new List<string>();
                StreamReader sr = new StreamReader(textBox__XYZFromFile.Text);
                string line;
                while ((line = sr.ReadLine()) != null) { /*Console.WriteLine(line);*/ string_lenghts = line.Split(',', ' ', '\n').ToList(); }
                sr.Close();

                List<int> int_lengths = new List<int>();
                foreach (var str in string_lenghts)
                {
                    try
                    {
                        Console.WriteLine(str);
                        int_lengths.Add(Int32.Parse(str));
                    }
                    catch (Exception exc)
                    {
                        OutputLogWrite(exc.ToString());
                    }
                }

                OutputLogWrite("Float list done");

                List<System.Numerics.Vector3> vec3list = parser.ParseDataFromAboveScan(int_lengths, communicator.toolPositions, 682, 5.0f);

                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

                StreamWriter sw = new StreamWriter(textBox__XYZToFile.Text, false);
                foreach (var vec3 in vec3list)
                {
                    sw.WriteLine(vec3.X + " " + vec3.Y + " " + vec3.Z);
                }
                sw.Close();
            }
            catch (Exception exc)
            {
                OutputLogWrite(exc.ToString());
            }
        }

        private void button__DXFExport_Click(object sender, EventArgs e)
        {
            ParserDXF parser = new ParserDXF();
            parser.generateDXF(textBox__DXFFromFile.Text);
            //Console.ReadLine();
        }


        public void OutputLogWrite(string message)
        {
            richTextBox__OutputLog.Text = "-----------------------------------------------" +
                    "-----------------------------------------------" +
                    "-----------------------------------------------\n" + richTextBox__OutputLog.Text;
            richTextBox__OutputLog.Text = message + "\n" + richTextBox__OutputLog.Text;
        }

        public void SetRobotConnection(bool isConnected)
        {
            isRobotConnected = isConnected;
            if (isConnected == true)
            {
                label__CheckRobot.Text = "Connected";
                label__CheckRobot.ForeColor = Color.Green;
                OutputLogWrite("Robot connected");
            }
            else if (isConnected == false)
            {
                label__CheckRobot.Text = "Disconnected";
                label__CheckRobot.ForeColor = Color.Red;
                OutputLogWrite("Robot not connected");
                OutputLogWrite(communicator.robotClient.excpt);
                communicator.DisconnectRobot();
            }
        }

        private void backgroundWorker__automatedScan_DoWork(object sender, DoWorkEventArgs e)
        {
            AutomatedScan();
        }
    }
}
