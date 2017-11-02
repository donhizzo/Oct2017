using System;
using DataStore;
using BuisnessLayer;
using System.Collections.Generic;
using BuisnessLayer.Implementations;
using BuisnessLayer.Interfaces;
using TestApp.DataHelper;

namespace TestApp
{
    class Program
    {
       

        static void Main(string[] args)
        {
            var customers = CutomerDataHelper.GetCustomer();
            var employees = EmployeeDataGenerator.GetEmployee();
            CustomerService customerService1 = new CustomerService();// This has all the methods.
            ICustomerService<Customer> customerService2 = new CustomerService();// This has methods only from ICutomerService
            IBaseRepository<Customer> customerService3 = new CustomerService();//This has mehtodds only from IBaseRpeository
            var employeeService = new EmployeeService();
            //customerService.
            
          
            Console.WriteLine("Hello World!");
        }
    }
}
