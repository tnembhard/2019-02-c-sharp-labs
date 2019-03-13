using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Project.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        [ForeignKey("Library")]
        public ICollection<Library> Library { get; set; }
    }
}
