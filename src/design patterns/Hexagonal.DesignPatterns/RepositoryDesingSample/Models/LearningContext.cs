using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Interfaces.Entities;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Models.Configurations;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Models.Entities;

namespace Hexagonal.DesignPatterns.RepositoryDesingSample.Models
{
    public partial class LearningContext : DbContext
    {
        public LearningContext()
        {
        }

        public LearningContext(DbContextOptions<LearningContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSI\\LEARNING;Database=Learning;Trusted_Connection=True;");
            }

            optionsBuilder.UseSqlServer("Server=MSI\\LEARNING;Database=Learning;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Learning
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
        }
    }
}
