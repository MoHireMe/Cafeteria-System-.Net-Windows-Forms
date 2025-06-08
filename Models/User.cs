using Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        private UserRole role;

        [Key] 
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        public UserRole Role { get ; set; }   // Admin | Seller
    }
}
