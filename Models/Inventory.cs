using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Inventory
    {
        [Key] 
        public int Id { get; set; }
        [ForeignKey("Product")]
        public  int ProductId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        
        public int QuantityInStock { get; set; }
        public DateTime LastUpdated { get; set; }

    
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
