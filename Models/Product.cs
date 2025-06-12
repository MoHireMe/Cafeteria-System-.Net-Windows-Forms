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
        
        [Required, StringLength(100, MinimumLength = 3)]
        public string ProductName { get; set; }
        [Required]
        public decimal PricePerUnit { get; set; }
        [Required]
        public decimal Cost { get; set; }
        public int NumberOfUnitsInStore { get; set; }
        public bool IsStock { get; set; } = false;
        public bool IsBestSeller { get; set; } = false;
       
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public virtual ICollection<OrderItem>  OrderItem { get; set; } = new HashSet<OrderItem>();
        public Inventory Inventory { get; set; } 



    }
}
