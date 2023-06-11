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

            List<float> xList = new List<float>();
            List<float> yList = new List<float>();
            List<PointOrigin> pointOriginList = new List<PointOrigin>();
            List<float> angleWeightList = new List<float>();
            List<float> distanceWeightList = new List<float>();

            for (int i = 0; i < points.Count; i++)
            {
                xList.Add(points[i].X);
                yList.Add(points[i].Y);
                pointOriginList.Add(points[i].PointOrigin);
                angleWeightList.Add(points[i].angleWeight);
                distanceWeightList.Add(points[i].distanceWeight);
            }

            var jsonPattern = new JSONPattern
            {
                name = patternName,
                xList = xList,
                yList = yList,
                pointOriginList = pointOriginList,
                angleWeightList = angleWeightList,
                distanceWeightList = distanceWeightList
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
