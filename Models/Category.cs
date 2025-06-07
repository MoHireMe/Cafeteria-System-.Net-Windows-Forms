using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required, StringLength(12, MinimumLength = 3)]
        public string Title { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual ICollection<Product> Products { get; set; }= new HashSet<Product>();
        public virtual ICollection<Inventory> Inventories { get; set; }=new HashSet<Inventory>();
    }
}
