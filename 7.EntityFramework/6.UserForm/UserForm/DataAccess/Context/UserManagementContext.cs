using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class UserManagementContext : DbContext
    {
        public DbSet<CountryDetail> CountryDetailsData { get; set; }
        public DbSet<LanguageDetail> LanguageDetailsData { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-121UAJH; Database=UserFormManagement; Integrated Security=true;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
