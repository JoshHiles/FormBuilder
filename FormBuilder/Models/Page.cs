using System;
using System.Collections.Generic;

namespace FormBuilder.Models
{
    public class Page
    {
        public Guid Id { get; set; }

        public Guid FormId { get; set; }
        public Form Form { get; set; }

        public string Name { get; set; }

        public string FieldJson { get; set; }
    }
}