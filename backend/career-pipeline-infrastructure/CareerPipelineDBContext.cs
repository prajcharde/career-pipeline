using career_pipeline_domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace career_pipeline_infrastructure
{
    public class CareerPipelineDBContext: DbContext
    {
        public CareerPipelineDBContext(DbContextOptions<CareerPipelineDBContext> options): base(options)
        {

        }

        public DbSet<User> Users => Set<User>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<JobApplication> JobApplications => Set<JobApplication>();
        public DbSet<ApplicationHistory> ApplicationHistories => Set<ApplicationHistory>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<JobApplication>()
                .HasOne<Company>()
                .WithMany()
                .HasForeignKey(x => x.CompanyId);

            modelBuilder.Entity<ApplicationHistory>()
                .HasOne<JobApplication>()
                .WithMany()
                .HasForeignKey(x => x.JobApplicationId);
        }

    }

    
}
