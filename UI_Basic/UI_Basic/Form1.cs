using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Numerics;
using System.Threading;
using System.Collections;
using System.Globalization;

namespace UI_Basic
{
    public partial class Form1 : Form
    {
        static DistanceMeter distanceMeter;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            distanceMeter = new DistanceMeter();
            if (distanceMeter.PreparePort(textBox_COM.Text, textBox_BaudRate.Text))
            {
                label_CheckConnection.Text = "Connected";
                label_CheckConnection.ForeColor = Color.Green;
            }
        }

        private void button_StartStopScanning_Click(object sender, EventArgs e)
        {
            if (button_StartStopScanning.Text == "Start Scanning")
            {
                button_StartStopScanning.Text = "Stop Scanning";
                label_ScanningInProgress.Text = "Scanning";

                distanceMeter.MakeScan();

                if (distanceMeter.CloseConnection())
                {
                    label_CheckConnection.Text = "Disconnected";
                    label_CheckConnection.ForeColor = Color.Red;
                }
                else
                    Console.WriteLine("Cannot close connection");

                button_StartStopScanning.Text = "Start Scanning";
                label_ScanningInProgress.Text = "Not Scanning";
            }
            else if (button_StartStopScanning.Text == "Stop Scanning")
            {
                button_StartStopScanning.Text = "Start Scanning";
                label_ScanningInProgress.Text = "Not Scanning";
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            if (distanceMeter.CloseConnection())
            {
                label_CheckConnection.Text = "Disconnected";
                label_CheckConnection.ForeColor = Color.Red;
            }
            else
                Console.WriteLine("Cannot close connection");
        }

        private void button_exportScan_Click(object sender, EventArgs e)
        {
            distanceMeter.ExportDistancesToTxt(textBox_Filename.Text);
        }

        private void button_XYZimport_Click(object sender, EventArgs e)
        {
            XYZ_Parser parser = new XYZ_Parser();

            Console.WriteLine("Start parsing");

            List<string> string_lenghts = new List<string>();
            StreamReader sr = new StreamReader(textBox_XYZimport.Text);
            string line;
            while ((line = sr.ReadLine()) != null) { Console.WriteLine(line); string_lenghts = line.Split(',', ' ', '\n').ToList(); }
            sr.Close();

            List<int> int_lengths = new List<int>();
            foreach(var str in string_lenghts)
            {
                try
                {
                    Console.WriteLine(str);
                    int_lengths.Add(Int32.Parse(str));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            Console.WriteLine("Float list done");

            List<Vector3> vec3list = parser.ParseDataFromAboveScan(int_lengths, 682, 5.0f);

            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            StreamWriter sw = new StreamWriter(textBox_XYZexport.Text, false);
            foreach(var vec3 in vec3list)
            {
                sw.WriteLine(vec3.X + " " + vec3.Y + " " + vec3.Z);
            }
            sw.Close();
        }
    }
}
