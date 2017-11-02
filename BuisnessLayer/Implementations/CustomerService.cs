using BuisnessLayer.Interfaces;
using DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLayer.Implementations
{
    public class CustomerService : IBaseRepository<Customer>,ICustomerService<Customer>
    {
        public bool Create(Customer o)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomerWithBillingDue(int days = 10, int month = 3)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetOnlineCustomers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetPendingCutomerRegistrations()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetPrimeCutomers()
        {
            throw new NotImplementedException();
        }

        public bool IsPrimeCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer o)
        {
            throw new NotImplementedException();
        }
    }
}
