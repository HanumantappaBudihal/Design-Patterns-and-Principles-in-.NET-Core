using RepositoryDesingSample.Interfaces.Entities;
using System.Collections.Generic;

namespace RepositoryDesingSample.Interfaces.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<IEmployee> GetAll();
        IEmployee GetById(int EmployeeID);
        void Insert(IEmployee employee);
        void Update(IEmployee employee);
        void Delete(int EmployeeID);
        void Save();
    }
}
