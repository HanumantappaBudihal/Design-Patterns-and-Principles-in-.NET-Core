using Microsoft.EntityFrameworkCore;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Interfaces.Entities;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Interfaces.Repository;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Models;
using Hexagonal.DesignPatterns.RepositoryDesingSample.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hexagonal.DesignPatterns.RepositoryDesingSample.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly LearningContext _learningContext;
        public EmployeeRepository(LearningContext learningContext)
        {
            _learningContext = learningContext;
        }

        public IEnumerable<IEmployee> GetAll()
        {
            return _learningContext.Employees.ToList();
        }

        public IEmployee GetById(int EmployeeID)
        {
            return _learningContext.Employees.Find(EmployeeID);
        }

        public void Insert(IEmployee employee)
        {
            _learningContext.Employees.Add((Employee)employee);
        }
        public void Update(IEmployee employee)
        {
            _learningContext.Entry(employee).State = EntityState.Modified;
        }
        public void Delete(int EmployeeID)
        {
            IEmployee employee = _learningContext.Employees.Find(EmployeeID);
            _learningContext.Employees.Remove((Employee)employee);
        }

        public void Save()
        {
            _learningContext.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _learningContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

    }
}
