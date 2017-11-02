using BuisnessLayer.Interfaces;
using DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer.Implementations
{
    public class EmployeeService : IBaseRepository<Employee>,IEmployeeService<Employee>
    {
        public bool Create(Employee o)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee id)
        {
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Get()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeManger(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployeeOnVaccation()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetEmployeeTasks(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee o)
        {
            throw new NotImplementedException();
        }
    }
}
