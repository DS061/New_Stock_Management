using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stock_Management.Models
{
    public class Bill_Payment_Master
    {
        // primary Key 
        [Key]
        public int Bill_ID { get; set; }
        [Required]
        public string Company_Name { get; set; }
       [Required]
        public int Amount { get; set; }
       
        public string type { get; set; }

        [Required]
        public DateTime Payment_Date { get; set; }
    }
}
