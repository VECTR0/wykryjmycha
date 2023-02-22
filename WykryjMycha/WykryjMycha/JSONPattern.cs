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
    public class JSONPattern
    {
        public string name { get; set; }
        public List<float> coords { get; set; }
    }
}
