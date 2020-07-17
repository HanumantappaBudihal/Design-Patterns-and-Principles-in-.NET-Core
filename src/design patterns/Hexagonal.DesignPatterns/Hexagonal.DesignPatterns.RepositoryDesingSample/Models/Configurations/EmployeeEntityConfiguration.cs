using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Models.Entities;

namespace Hexagonal.DesignPatterns.RepositoryDesingSample.Models.Configurations
{
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        private const string _tableName = "Employees";
        private const string _schemaName = "dbo";

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable(_tableName, _schemaName);
            builder.HasKey(e => new { e.EmployeeId });
        }
    }
}
