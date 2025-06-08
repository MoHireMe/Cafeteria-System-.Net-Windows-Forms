using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderItem
    {

        [Key] 
        public int Id { get; set; }
        [Required]
        public int NumberOfUnits { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }


        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
