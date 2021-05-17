using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stock_Management.Models
{
    public class Client_Master
    {
        [Key]
        public int Client_ID { get; set; }
        [Required]
        public string Client_Name { get; set; }
        [Required]
        public string Client_Mobile { get; set; }
        [Required]
        public string Client_Address { get; set; }
        [Required]
        public DateTime Client_Edate { get; set; }

    }
}
