using DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer.Interfaces
{
    public interface IEmployeeService<T> where T : Employee
    {
        IEnumerable<T> GetEmployeeOnVaccation();
        T GetManager(int id);
    }
}
