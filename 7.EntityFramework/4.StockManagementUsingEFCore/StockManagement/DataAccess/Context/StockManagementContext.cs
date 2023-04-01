using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class StockManagementContext : DbContext
    {
        public DbSet<PurchaseDetails> PurchaseDetailData { get; set; }
        public DbSet<SaleDetails> SalesData { get; set; }

        public DbSet<Products> ProductsData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-121UAJH; Database=StockManagement; Integrated Security=true;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
