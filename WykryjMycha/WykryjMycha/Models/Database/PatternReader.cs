using System.Text.Json;

namespace WykryjMycha
{
    internal class PatternReader
    {
        private string filename;
        private string jsonContent;
        public List<Point> points { get; set; }
        public string patternName { get; set; }

        public PatternReader(string filename)
        {
            this.filename = filename;

            jsonContent = File.ReadAllText(filename);

            var jpattern = JsonSerializer.Deserialize<JSONPattern>(jsonContent);

            this.patternName = jpattern.name;


            this.points = new List<Point>();

            for (int i = 0; i < jpattern.xList.Count; i++)
            {
                this.points.Add(
                    new Point
                    {
                        X = jpattern.xList[i],
                        Y = jpattern.yList[i],
                        PointOrigin = jpattern.pointOriginList[i],
                        angleWeight = jpattern.angleWeightList[i],
                        distanceWeight = jpattern.distanceWeightList[i]
                    });
            }
        }
    }
}
