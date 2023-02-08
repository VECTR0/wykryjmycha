using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WykryjMycha
{
    public class Step
    {
        public string name;
        public List<Vector2> points;
        public List<Vector2> pattern;
    }

    public class Pattern
    {
        public string name;
        public List<Vector2> points;
        public List<Step> steps;
    }
}
