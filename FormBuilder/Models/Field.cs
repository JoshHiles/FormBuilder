using System;
using System.Collections.Generic;

namespace FormBuilder.Models
{
    public class Field
    {
        public string type { get; set; }
        public string subtype { get; set; }
        public string label { get; set; }
        public string className { get; set; }
        public string name { get; set; }
        public List<Value> values { get; set; }
    }
}