using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;

namespace UI_Basic
{
    public class DistanceMeter
    {
        static SerialPort urg;
        //public const int GET_NUM = 1;
        public const int start_step = 0;
        public const int end_step = 760;
        public List<long> distances;
        static long time_stamp;

        public DistanceMeter()
        {
        }

        public bool PreparePort(string portName, string baudRate)
        {
            try
            {
                urg = new SerialPort(portName, Int32.Parse(baudRate));
                urg.NewLine = "\n\n";

                urg.Open();

                Console.WriteLine("Connected to device");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool MakeScan()
        {
            try
            {

                urg.Write(SCIP_Writer.SCIP2());
                urg.ReadLine(); // ignore echo back
                urg.Write(SCIP_Writer.MD(start_step, end_step));
                urg.ReadLine(); // ignore echo back

                distances = new List<long>();
                time_stamp = 0;

                string receive_data = urg.ReadLine();
                if (!SCIP_Reader.MD(receive_data, ref time_stamp, ref distances))
                {
                    Console.WriteLine(receive_data);
                    return false;
                }
                if (distances.Count == 0)
                {
                    Console.WriteLine(receive_data);
                    return false;
                }
                // show distance data

                for (int j = 0; j < distances.Count; j++)
                {
                    Console.WriteLine("time stamp: " + time_stamp.ToString() + " distance " + j + " is: " + distances[j].ToString());
                }

                urg.Write(SCIP_Writer.QT()); // stop measurement mode
                urg.ReadLine(); // ignore echo back

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            { 
                urg.Close();
                Console.WriteLine("Disconnected from device");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


        public bool ExportDistancesToTxt(string path)
        {
            try
            {

                StreamWriter sw = new StreamWriter(path, true);
                int k = 0;
                for (int i = 0; i < distances.Count(); i++)
                {
                    if (i > 43 && i < 726)
                    {
                        k++;
                        sw.Write(distances[i].ToString() + ",");
                        Console.WriteLine("K: " + k + ", written dist: " + distances[i]);
                    }
                }

                sw.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
    
}
