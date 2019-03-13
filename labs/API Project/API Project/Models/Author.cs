using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Project.Models
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Publisher { get; set; }

    }
}
