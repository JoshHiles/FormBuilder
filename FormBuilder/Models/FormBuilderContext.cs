using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FormBuilder.Models
{
    public class FormBuilderContext : DbContext
    {
        public FormBuilderContext(DbContextOptions<FormBuilderContext> options)
            : base(options)
        { }

        public DbSet<Form> Forms { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}
