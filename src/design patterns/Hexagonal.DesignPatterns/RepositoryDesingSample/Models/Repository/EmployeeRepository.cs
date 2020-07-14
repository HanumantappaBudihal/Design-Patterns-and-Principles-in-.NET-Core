using RepositoryDesingSample.Interfaces.Entities;
using RepositoryDesingSample.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace RepositoryDesingSample.Models.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        
        public void Delete(int EmployeeID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IEmployee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEmployee GetById(int EmployeeID)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEmployee employee)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(IEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
