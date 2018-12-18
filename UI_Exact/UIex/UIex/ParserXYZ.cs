using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Numerics;

namespace UIex
{
    class ParserXYZ
    {
        public List<Measurement> measurements = new List<Measurement>();


        public ParserXYZ()
        {

        }

        public List<Vector3> ParseDataFromAboveScan(List<int> lengths_list, int range, float movementStep)
        {

            CreateListOfMeasurements(lengths_list, range);

            List<Vector3> vec3list = new List<Vector3>();

            float angleStep = 240.0f / (float)range;

            foreach (var mes in measurements)
            {
                float currentAngle = -120.0f;
                for (int i = 0; i < mes.mesments.Count(); i++)
                {
                    Vector3 vec3 = new Vector3();
                    vec3.X = mes.mesments[i] * (float)Math.Sin(currentAngle * Math.PI / 180.0f);
                    vec3.Y = mes.mesments[i] * (float)Math.Cos(currentAngle * Math.PI / 180.0f);
                    vec3.Z = movementStep * (mes.i);

                    vec3list.Add(vec3);

                    currentAngle += angleStep;
                }
            }

            return vec3list;
        }

        public void CreateListOfMeasurements(List<int> lengths_list, int range)
        {
            int divisor = lengths_list.Count() / range;

            for (int i = 0; i < divisor; i++)
            {
                List<float> mesments = new List<float>();

                for (int j = 0; j < range; j++)
                {
                    mesments.Add((float)lengths_list[j + range * i]);
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