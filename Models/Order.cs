using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Order
    {
        [Key]
        public  int Id { get; set; } 
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; } 

        public virtual ICollection<OrderItem> OrderItems { get; set; }= new HashSet<OrderItem>();
    }
}
