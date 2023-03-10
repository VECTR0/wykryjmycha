using System.Text.Json;

namespace WykryjMycha
{
    internal class PatternWriter
    {
        public static void Write(List<Point> points, string patternName)
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

            if (!Directory.Exists("patterns"))
            {
                Directory.CreateDirectory("patterns");
            }

            string filepath = "patterns/" + patternName + ".json";

            File.WriteAllText(filepath, jsonString);
        }

        public static void Delete(string filename)
        {
            string filepath = "patterns/" + filename + ".json";

            File.Delete(filepath);
        }
    }
}
