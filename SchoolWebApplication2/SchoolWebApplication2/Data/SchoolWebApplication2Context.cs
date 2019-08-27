using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SchoolWebApplication2.Models
{
    public class SchoolWebApplication2Context : DbContext
    {
        public SchoolWebApplication2Context (DbContextOptions<SchoolWebApplication2Context> options)
            : base(options)
        {
        }

        public DbSet<SchoolWebApplication2.Models.Animal> Animal { get; set; }
    }
}
