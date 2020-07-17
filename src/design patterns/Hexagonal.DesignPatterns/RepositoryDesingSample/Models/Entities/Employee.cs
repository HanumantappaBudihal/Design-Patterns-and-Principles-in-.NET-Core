using Hexagonal.DesignPatterns.RepositoryDesingSample.Interfaces.Entities;

namespace Hexagonal.DesignPatterns.RepositoryDesingSample.Models.Entities
{
    public partial class Employee : IEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Salary { get; set; }
        public string Department { get; set; }
    }
}
