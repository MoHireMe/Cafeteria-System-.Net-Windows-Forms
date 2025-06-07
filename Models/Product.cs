using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(12, MinimumLength = 3)]
        public string ProductName { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal Cost { get; set; }
        public string SKU { get; set; }
       
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual ICollection<Inventory> Inventories { get; set; } = new HashSet<Inventory>();



    }
}
