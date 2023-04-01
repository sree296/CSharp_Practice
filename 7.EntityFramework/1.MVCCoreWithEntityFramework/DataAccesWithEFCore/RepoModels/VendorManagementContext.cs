using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesWithEFCore.RepoModels
{
    public class VendorManagementContext : DbContext
    {
        public DbSet<Vendor> VendorDetailData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-121UAJH; Database=INVENTORY_MANAGEMENT; Integrated Security=true");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
