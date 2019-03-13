using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_Project.Models;

    public class LibContext : DbContext
    {
        public LibContext(DbContextOptions<LibContext> options)
            : base(options)
        {
        }


    public DbSet<Library> Library { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Author> Author { get; set; }
    public DbSet<Book> Book { get; set; }
    public DbSet<Orders> Orders { get; set; }
}
