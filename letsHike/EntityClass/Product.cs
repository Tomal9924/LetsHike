using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class Product:Entity
    {
        [Key]
        public int Product_Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public double Product_Price { get; set; }
        [Required]
        public string Status { get; set; }
        
    }
}
