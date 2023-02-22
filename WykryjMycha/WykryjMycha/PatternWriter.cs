using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Reflection.Metadata;
using System.Globalization;
using System.Numerics;

namespace WykryjMycha
{
    public class PatternWriter
    {
        public static void write(List<Vector2> points, string patternName)
        {
            if (points == null || patternName == null)
            {
                throw new NullReferenceException();
            }

            List<float> coordList = new List<float>();

            for (int i = 0; i < points.Count; i++)
            {
                coordList.Add(points[i].X);
                coordList.Add(points[i].Y);
            }

            var jsonPattern = new JSONPattern
            {
                name = patternName,
                coords = coordList
            };

            string jsonString = JsonSerializer.Serialize(jsonPattern);
            string filepath = "patterns/" + patternName + ".json";

            Console.WriteLine(jsonString);

            File.WriteAllText(filepath, jsonString);
        }
    }
}
