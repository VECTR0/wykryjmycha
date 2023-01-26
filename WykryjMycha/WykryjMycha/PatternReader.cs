using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Reflection.Metadata;
using System.Globalization;

namespace WykryjMycha
{
    public class PatternReader
    {
        private string jsonContent;

        public PatternReader(string filepath)
        {
            if(filepath == null)
            {
                throw new ArgumentNullException();
            }

            jsonContent = File.ReadAllText(filepath);
        }

        private List<double> convertStringToCoordsList(string coordinatesList)
        {
            List<double> coords = new List<double>();
            String[] coordinates = coordinatesList.Split(',');

            for (int i = 0; i < coordinates.Length; i++)
            {
                double currentCoord = Double.Parse(coordinates[i], CultureInfo.InvariantCulture);
                coords.Add(currentCoord);
            }
            return coords;
        }

        private List<double> coordsToAngles (List<double> coords)
        {
            List<double> angles = new List<double>();

            double newX = Convert.ToDouble(coords[0]);
            double newY = Convert.ToDouble(coords[1]);

            double oldX;
            double oldY;

            for (int i = 2; i < coords.Count; i += 2)
            {
                oldX = newX;
                oldY = newY;

                newX = Convert.ToDouble(coords[i]);
                newY = Convert.ToDouble(coords[i + 1]);

                double dx = newX - oldX;
                double dy = newY - oldY;

                double angle = Math.Atan2(dy, dx) * 180.0 / Math.PI;

                angles.Add(angle);
            }

            return angles;
        }

        public List<double> parseToAngles()
        {
            var jpattern = JsonSerializer.Deserialize<JSONPattern>(jsonContent);

            List<double> coordinates = convertStringToCoordsList(jpattern.coordList);

            List<double> angles = coordsToAngles(coordinates);

            return angles;
        }
    }
}
