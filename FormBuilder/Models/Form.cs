using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormBuilder.Models
{
    public class Form
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public List<Page> Pages { get; set; }
    }
}
