namespace RepositoryDesingSample.Interfaces.Entities
{
    public interface IEmployee
    {
        int EmployeeId { get; set; }
        string Name { get; set; }
        string Gender { get; set; }
        int? Salary { get; set; }
        string Department { get; set; }
    }
}
