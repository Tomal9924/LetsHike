using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass
{
    public class Payment:Entity
    {
        [Key]
        public int Payment_Id { get; set; }
        [Required]
        public string Payment_Type { get; set; }


        [ForeignKey("Payment_Id")]
        public Package Package { get; set; }
        
         [Required]
        public double amount { get; set; }
    }
}
