using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
   public class Package:Entity
    {

       [Key]
       
        public int Package_Id { get; set; }
        [Required]
        public string Package_Name { get; set; }

        [Required]
        public string Package_Details { get; set; }
        
        
    }
}
