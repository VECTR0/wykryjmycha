using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    public class AngleMetric : IMetric
    {
        public float GetValue(PatternMatchingResult result)
        {
            return result.maxRotationAngle;
        }
    }
}
