using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class PatternReader
    {
        private string filename;
        private string jsonContent;
        private List<float> coords;

        public List<Vector2> points { get; set; }
        public string patternName { get; set; }

        public PatternReader(string filename)
        {
            this.filename = filename;

            jsonContent = File.ReadAllText(filename);

            Console.WriteLine(jsonContent);

            var jpattern = JsonSerializer.Deserialize<JSONPattern>(jsonContent);

            this.patternName = jpattern.name;
            this.coords = jpattern.coords;
            this.points = ToVector2List(jpattern.coords);
        }

        private List<Vector2> ToVector2List(List<float> coords)
        {
            List<Vector2> points = new List<Vector2>();

            for (int i = 0; i < coords.Count; i += 2)
            {
                points.Add(new Vector2(coords[i], coords[i + 1]));
            }

            return points;
        }
    }
}
