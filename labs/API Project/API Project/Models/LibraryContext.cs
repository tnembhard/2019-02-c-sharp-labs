using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace API_Project.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("MyLibrary")
        {
        }

        public DbSet<Library> Library { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Orders> Orders { get; set; }

    }
}
