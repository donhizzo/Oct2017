using DataStore;
using System;
using System.Collections.Generic;


namespace TestApp.DataHelper
{
    public class EmployeeDataGenerator
    {
        public static IEnumerable<Employee> GetEmployee()
        {
            var results = new List<Employee>()
            {
                new Employee {Id = 10, FirstName = "Vasu", LastName = "Mangla", EmployeeDepartment = new Department(){
                Id = 1,
                DepartmentName = "IT"}, HireDate = DateTime.Now, UserAddress = new SubAddress()
                {
                    City = "Falls church",
                    State = "VA",
                    Country = "USA"
                } },

                new Employee {Id = 1, FirstName = "Don", LastName = "Hizzo", EmployeeDepartment = new Department(){
                Id = 1,
                DepartmentName = "IT"}, HireDate = DateTime.Now, UserAddress = new SubAddress()
                {
                    City = "Fairfax",
                    State = "VA",
                    Country = "USA"
                } },
                 new Employee {Id = 2, FirstName = "Solomon", LastName = "Grandy", EmployeeDepartment = new Department(){
                Id = 1,
                DepartmentName = "HR"}, HireDate = DateTime.Now, UserAddress = new SubAddress()
                {
                    City = "Fairfax",
                    State = "VA",
                    Country = "USA"
                } },
                  new Employee {Id = 3, FirstName = "Calacia", LastName = "Kiel", EmployeeDepartment = new Department(){
                Id = 1,
                DepartmentName = "Finance"}, HireDate = DateTime.Now, UserAddress = new SubAddress()
                {
                    City = "Annadale",
                    State = "VA",
                    Country = "USA"
                } },
                   new Employee {Id = 4, FirstName = "Subu", LastName = "Venkatraman", EmployeeDepartment = new Department(){
                Id = 1,
                DepartmentName = "HR"}, HireDate = DateTime.Now, UserAddress = new SubAddress()
                {
                    City = "Salt Lake City",
                    State = "UT",
                    Country = "USA"
                } }

        };
            return results;
        }

    }
}
