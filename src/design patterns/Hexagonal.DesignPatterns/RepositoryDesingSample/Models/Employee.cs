using System;
using System.Collections.Generic;

namespace RepositoryDesingSample.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Salary { get; set; }
        public string Department { get; set; }
    }
}
