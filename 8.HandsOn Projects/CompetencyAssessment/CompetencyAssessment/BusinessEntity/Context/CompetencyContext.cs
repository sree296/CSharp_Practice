using BusinessEntity.BEModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.Context
{
    public class CompetencyContext: DbContext
    {
        public DbSet<UserInfo> UserInfoData { get; set; }
        public DbSet<RoleDetail> RoleDetailData { get; set; }
        public DbSet<AssessmentDetail> AssessmentDetailData { get; set; }
        public DbSet<CaseStudyDetail> CaseStudyDetailData { get; set; }
        public DbSet<CaseStudySolution> CaseStudySolutionData { get; set; }
        public DbSet<CompetencyDetail> CompetencyDetailData { get; set; }
        public DbSet<AssessmentUserMapping> AssessmentUserMappingData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-121UAJH; Database=CompetencyAssessment; Integrated Security=true;TrustServerCertificate=True");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
