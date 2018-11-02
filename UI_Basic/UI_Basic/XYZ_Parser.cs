using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace UI_Basic
{
    class XYZ_Parser
    {
        public List<Measurement> measurements = new List<Measurement>();
        public List<Vector3> vec3list = new List<Vector3>();


        public XYZ_Parser()
        {

        }

        public List<Vector3> ParseDataFromAboveScan(List<int> lengths_list, int range, float movementStep)
        {

            CreateListOfMeasurements(lengths_list, range);

            float angleStep = 360.0f / (float)range;
            float currentAngle = -120.0f;

            foreach(var mes in measurements)
            {
                for (int i = 0; i < mes.mesments.Count(); i++)
                {
                    Vector3 vec3 = new Vector3();
                    vec3.X = mes.mesments[i] * (float)Math.Sin(currentAngle);
                    vec3.Y = movementStep * mes.i;
                    vec3.Z = mes.mesments[i] * (float)Math.Cos(currentAngle);

                    vec3list.Add(vec3);
                }
            }

            return vec3list;
        }

        public void CreateListOfMeasurements(List<int> lengths_list, int range)
        {
            int divisor = lengths_list.Count() / range;

            for (int i = 1; i <= divisor; i++)
            {
                List<float> mesments = new List<float>();

                for (int j = 0; j < range; j++)
                {
                    mesments.Add((float)lengths_list[j * i]);
                }

                measurements.Add(new Measurement(i, mesments));
            }
        }


        public class Measurement
        {
            public List<float> mesments;
            public int i;

            public Measurement(int i, List<float> mesments)
            {
                this.i = i;
                this.mesments = mesments;
            }
        }
    }
}
