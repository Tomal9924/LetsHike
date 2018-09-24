using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EntityClass
{
    public class Traveller:Entity
    {
        [Key]
        public int Traveller_Id { get; set; }
        [Required]
        public string Name { get; set; }

        
        public string Phone { get; set; }
        
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        
        
        public string Password { get; set; }
    }
}
