using System;
using DataStore;
using BuisnessLayer;
using System.Collections.Generic;
using BuisnessLayer.Implementations;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var empObj = new Employee();
            empObj.Id = 10;
            empObj.FirstName = "Vasu";
            empObj.EmployeeDepartment = new Department()
            {
                Id = 1,
                DepartmentName = "IT"
            };
            empObj.UserAddress = new SubAddress()
            {
                City="Falls Church",
                State="VA",
                Country="USA"
            };
            var custObj = new Customer();

            custObj.Id = 10;
            custObj.FirstName = "Vasu";
            custObj.CustomerOrders = new List<Order>()
            {
               new Order{ID=1,OrderAmount=10,OrderDate=System.DateTime.Now},
               new Order{ID=1,OrderAmount=10,OrderDate=System.DateTime.Now},
               new Order{ID=1,OrderAmount=10,OrderDate=System.DateTime.Now},
               new Order{ID=1,OrderAmount=10,OrderDate=System.DateTime.Now},
               new Order{ID=1,OrderAmount=10,OrderDate=System.DateTime.Now}

            };
            custObj.UserAddress = new SubAddress()
            {
                City = "Falls Church",
                State = "VA",
                Country = "USA"
            };

            var customerService = new CustomerService();
            var employeeService = new EmployeeService();

            customerService.Create(custObj);
            employeeService.Create(empObj);

            Console.WriteLine("Hello World!");
        }
    }
}
