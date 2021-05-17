using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace New_Stock_Management.Models
{
    public class Stock_Master
    {
        [Key]
        public int Stock_ID { get; set; }
        [Required]
        public string Company_Name { get; set; }
        [Required]
        public string Item_Name { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public int Total_Qty { get; set; }
        [Required]
        public int Available_Qty { get; set; }
        [Required]
        public int Sell_Qty { get; set; }
        [Required]
        public int Available_Price { get; set; }
        [Required]
        public int sell_price { get; set; }

        
    }
}
