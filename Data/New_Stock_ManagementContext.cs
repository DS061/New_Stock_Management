using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using New_Stock_Management.Models;

namespace New_Stock_Management.Data
{
    public class New_Stock_ManagementContext : DbContext
    {
        public New_Stock_ManagementContext (DbContextOptions<New_Stock_ManagementContext> options)
            : base(options)
        {
        }

        public DbSet<New_Stock_Management.Models.Client_Master> Client_Master { get; set; }

        public DbSet<New_Stock_Management.Models.Company_Master> Company_Master { get; set; }

        public DbSet<New_Stock_Management.Models.Stock_in_Master> Stock_in_Master { get; set; }

        public DbSet<New_Stock_Management.Models.Sale_Master> Sale_Master { get; set; }

        public DbSet<New_Stock_Management.Models.Payment_Master> Payment_Master { get; set; }

        public DbSet<New_Stock_Management.Models.Stock_Master> Stock_Master { get; set; }

        public DbSet<New_Stock_Management.Models.Stock_Return_Master> Stock_Return_Master { get; set; }

        public DbSet<New_Stock_Management.Models.Bill_Payment_Master> Bill_Payment_Master { get; set; }
    }
}
