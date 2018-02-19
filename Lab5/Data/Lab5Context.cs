using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Models
{
    public class Lab5Context : DbContext
    {
        public Lab5Context (DbContextOptions<Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Lab5.Models.Movie> Movie { get; set; }
    }
}
