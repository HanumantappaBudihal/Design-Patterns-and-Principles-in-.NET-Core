using RepositoryDesingSample.Interfaces.Entities;

namespace RepositoryDesingSample.Models.Entities
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
