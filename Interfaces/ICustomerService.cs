using DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer.Interfaces
{
    public interface ICustomerService<T> where T : Customer
    {
        IEnumerable<T> GetPrimeCustomers();
        bool IsPrimeCustomer(int id);
        IEnumerable<Customer> GetCustomerWithBillingDue(int days = 10, int month = 3);
    }
}
