using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Project.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }

        [ForeignKey("Book")]
        public ICollection<Book> Book { get; set; }

        [ForeignKey("Customer")]
        public ICollection<Customer> Customer { get; set; }
    }
}
