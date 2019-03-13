using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API_Proj.Models
{
    public class Library
    {
        public int LibraryID { get; set; }
        public string LibraryName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public int BookQuantity { get; set; }
        public string BookAuthor { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Publisher { get; set; }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
    }

    public class BookLibrary : DbContext
    {
        public DbSet<Library> Library { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public BookLibrary() { }

        public BookLibrary(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "BookLibrary.db");
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=BookLibrary;" + "Integrated Security=true;" + "MultipleActiveResultSets=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
