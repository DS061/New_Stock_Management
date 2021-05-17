using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stock_Management.Models
{
    public class Company_Master
    {
        [Key]
        public int Company_ID { get; set; }
        [Required]
        public string Company_Name { get; set; }
        [Required]
        public string Contact_Number { get; set; }
        [Required]
        public string Company_Address { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public DateTime Company_Edate { get; set; }
    }
}
