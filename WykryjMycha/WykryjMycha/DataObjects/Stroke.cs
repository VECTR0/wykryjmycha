using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WykryjMycha
{
    public class Stroke
    {
        public string name { get; set; }
        public List<Vector2> points { get; set; }
        public bool isPattern { get; set; }
    }
}
