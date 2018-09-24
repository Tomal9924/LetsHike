using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class Admin:Entity
    {
        [Key]
        public int Admin_Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
       
        public string Phone { get; set; }
        
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        
        public string Password { get; set; }
    }
}
