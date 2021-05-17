using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stock_Management.Models
{
    public class Stock_in_Master
    {
        [Key]
        public int Stock_ID { get; set; }
        [Required]
        public string Company_Name { get; set; }
        [Required]
        public string Item_Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public int Buy_Price { get; set; }
        [Required]
        public int Sell_Price { get; set; }
        [Required]
        public string Location { get; set; }
        
        [Required]
        public DateTime Stock_Edate { get; set; }
    }
}
