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

namespace Testy_RS_232C_etc
{
    public partial class Form1 : Form
    {
        static Listener listener;
        static Thread listenerThread;
        public Form1()
        {
            InitializeComponent();

            InitializeComponents();        
        }

        public void InitializeComponents()
        {
            // Badu rates
            comboBox_BaudRate.Items.Add("110");
            comboBox_BaudRate.Items.Add("300");
            comboBox_BaudRate.Items.Add("600");
            comboBox_BaudRate.Items.Add("1200");
            comboBox_BaudRate.Items.Add("2400");
            comboBox_BaudRate.Items.Add("4800");
            comboBox_BaudRate.Items.Add("9600");
            comboBox_BaudRate.Items.Add("14400");
            comboBox_BaudRate.Items.Add("19200");
            comboBox_BaudRate.Items.Add("38400");
            comboBox_BaudRate.Items.Add("57600");
            comboBox_BaudRate.Items.Add("115200");
            comboBox_BaudRate.Items.Add("128000");
            comboBox_BaudRate.Items.Add("256000");
        }

        private void button_ListenStartStop_Click(object sender, EventArgs e)
        {
            if (button_ListenStartStop.Text == "Listen Start" && comboBox_BaudRate.Text != "" && textBox_ChooseCOM.Text != "")
            {
                button_ListenStartStop.Text = "Listen Stop";
                listener = new Listener(textBox_ChooseCOM.Text, Int32.Parse(comboBox_BaudRate.Text), Int32.Parse(textBox_DataBitsValue.Text));
                listenerThread = new Thread(PortRead);
                try
                {
                    listener.sPort.Open();
                }
                catch { }
                listenerThread.Start();

                }
            else if (button_ListenStartStop.Text == "Listen Stop")
            {
                button_ListenStartStop.Text = "Listen Start";
                listenerThread.Join();
                listener.sPort.Close();
            }
        }

        public void PortRead()
        {
            while(button_ListenStartStop.Text == "Listen Stop")
            {
                try
                {
                    string message = listener.sPort.ReadLine();
                    Console.WriteLine(message);
                }
                catch { }
            }
        }
    }
}
