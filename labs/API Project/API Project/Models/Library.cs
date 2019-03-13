using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace API_Project.Models
{
    [Table("Library")]
    public class Library
    {
        [Key]
        public int LibraryID { get; set; }
        public string LibraryName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
    }



}
