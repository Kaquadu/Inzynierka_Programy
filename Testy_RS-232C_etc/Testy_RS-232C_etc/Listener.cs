using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Testy_RS_232C_etc
{
    class Listener
    {
        public SerialPort sPort;
        public Listener(string COM, int baudRate, int dataBits)
        {
            InitializePort(COM, baudRate, dataBits);
        }

        public void InitializePort(string COM, int baudRate, int dataBits)
        {
            sPort = new SerialPort();
            // Allow the user to set the appropriate properties.
            sPort.PortName = SetPortName(COM);
            sPort.BaudRate = SetPortBaudRate(baudRate);
            sPort.Parity = SetPortParity(sPort.Parity);
            sPort.DataBits = SetPortDataBits(dataBits);
            sPort.StopBits = SetPortStopBits(sPort.StopBits);
            sPort.Handshake = SetPortHandshake(sPort.Handshake);
            // Timeouts
            sPort.ReadTimeout = 500;
            sPort.WriteTimeout = 500;
        }

        // Display Port values and prompt user to enter a port.
        public static string SetPortName(string defaultPortName)
        {
            Console.WriteLine("Available Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }
            Console.Write("COM value: {0}:", defaultPortName);

            if (defaultPortName == "" || !(defaultPortName.ToLower()).StartsWith("com"))
            {
                defaultPortName = "COM1";
            }
            return defaultPortName;
        }
        // Display BaudRate values and prompt user to enter a value.
        public static int SetPortBaudRate(int defaultPortBaudRate)
        {
            Console.Write("Baud Rate(current:{0}): ", defaultPortBaudRate);

            if (defaultPortBaudRate.ToString() == "")
            {
                defaultPortBaudRate = 9600;
            }

            return defaultPortBaudRate;
        }

        // Display PortParity values and prompt user to enter a value.
        public static Parity SetPortParity(Parity defaultPortParity)
        {
            Console.WriteLine("Available Parity options:");
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Parity value: {0}:", defaultPortParity.ToString(), true);

            return defaultPortParity;
        }
        // Display DataBits values and prompt user to enter a value.
        public static int SetPortDataBits(int defaultPortDataBits)
        {
            Console.Write("DataBits value (Default: {0}): ", defaultPortDataBits);

            if (defaultPortDataBits == 0)
            {
                defaultPortDataBits = 8;
            }

            return defaultPortDataBits;
        }

        // Display StopBits values and prompt user to enter a value.
        public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            Console.WriteLine("Available StopBits options:");
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("StopBits value (None is not supported and " +
             "raises an ArgumentOutOfRangeException. \n (Current: {0}):", defaultPortStopBits.ToString());

            return defaultPortStopBits;
        }
        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            Console.WriteLine("Available Handshake options:");
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Handshake value (Current: {0}):", defaultPortHandshake.ToString());


            return defaultPortHandshake;
        }
    }
}
