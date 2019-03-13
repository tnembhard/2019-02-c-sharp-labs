using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace API_Project.Models
{

    [Table("Books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public int BookQuantity { get; set; }
        public string BookAuthor { get; set; }
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("Author")]
        public ICollection<Author> Author { get; set; }
    }
}
