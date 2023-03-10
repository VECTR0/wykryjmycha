using System.Text.Json;

namespace WykryjMycha
{
    internal class PatternReader
    {
        private string filename;
        private string jsonContent;
        private List<float> coords;

        public List<Point> points { get; set; }
        public string patternName { get; set; }

        public PatternReader(string filename)
        {
            this.filename = filename;

            jsonContent = File.ReadAllText(filename);

            var jpattern = JsonSerializer.Deserialize<JSONPattern>(jsonContent);

            this.patternName = jpattern.name;
            this.coords = jpattern.coords;
            this.points = ToPointList(jpattern.coords);
        }

        private List<Point> ToPointList(List<float> coords)
        {
            List<Point> points = new List<Point>();

            for (int i = 0; i < coords.Count; i += 2)
            {
                points.Add(new Point(coords[i], coords[i + 1]));
            }

            return points;
        }
    }
}
