using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stock_Management.Models
{
    public class Payment_Master
    {

        [Key]
        public int Payment_ID { get; set; }
        [Required]
        public string Party_Name { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int Paid_Amt { get; set; }
        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime Payment_Edate { get; set; }
    }
}
