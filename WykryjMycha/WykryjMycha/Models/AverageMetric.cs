using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    internal class AverageMetric : IMetric
    {
        public float GetValue(PatternMatchingResult result)
        {
            return result.avgRotationAngle;
        }
    }
}
