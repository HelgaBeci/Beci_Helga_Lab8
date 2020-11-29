using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Beci_Helga_Lab8.Models;

namespace Beci_Helga_Lab8.Data
{
    public class Beci_Helga_Lab8Context : DbContext
    {
        public Beci_Helga_Lab8Context (DbContextOptions<Beci_Helga_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Beci_Helga_Lab8.Models.Book> Book { get; set; }

        public DbSet<Beci_Helga_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Beci_Helga_Lab8.Models.BookCategory> BookCategory { get; set; }

        public DbSet<Beci_Helga_Lab8.Models.Category> Category { get; set; }
    }
}
