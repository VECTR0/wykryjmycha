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
    public class PatternReader
    {
        public string filename { get; set; }
        public List<Vector2> points { get; set; }
        public List<Step> steps { get; set; }

        private string jsonContent;
        private string patternName;

        public PatternReader(string filename)
        {
            this.filename = filename;

            jsonContent = File.ReadAllText(filename);

            Console.WriteLine(jsonContent);

            var jpattern = JsonSerializer.Deserialize<Pattern>(jsonContent);

            this.patternName = jpattern.name;
            this.points = jpattern.points;
            this.steps = jpattern.steps;
        }
    }
}
