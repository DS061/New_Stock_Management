using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stock_Management.Models
{
    public class Stock_Return_Master
    {
        [Key]
        public int Stock_return_ID { get; set; }
       
        [Required]
        public string Company { get; set; }
        [Required]
        public string Item_Name { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Total_Price { get; set; }
        [Required]
        public DateTime Stock_Edate { get; set; }
    }
}
