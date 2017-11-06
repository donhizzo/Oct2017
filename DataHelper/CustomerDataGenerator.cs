using DataStore;
using System;
using System.Collections.Generic;
using System.Text;
using BuisnessLayer.Implementations;
using BuisnessLayer.Interfaces;

namespace TestApp.DataHelper
{
    public class CustomerDataGenerator
    {
        public static IEnumerable<Customer> GetCustomer()
        {
            var results = new List<Customer>()
            {
                new Customer { Id = 1, FirstName = "Don", LastName = "Hizzo", Email = "text@ymail.com",
                    CustomerOrders = new List<Order>()
                    {
                        new Order{ID=1,OrderAmount=10,OrderDate = DateTime.Now},
                        new Order{ID=1,OrderAmount=10,OrderDate = DateTime.Now},
                        new Order{ID=1,OrderAmount=10,OrderDate = DateTime.Now}
                    },
                    UserAddress = new SubAddress()
                    {
                        City = "Falls Church",
                        State = "VA",
                        Country = "USA"
                    }

                },
                new Customer { Id = 2, FirstName = "Cristiano", LastName = "Ronaldo", Email = "test@ymail.com",
                    CustomerOrders = new List<Order>()
                    {
                        new Order{ID=2,OrderAmount=1000,OrderDate = DateTime.Now},
                        new Order{ID=5,OrderAmount=600,OrderDate = DateTime.Now},
                        new Order{ID=7,OrderAmount=750,OrderDate = DateTime.Now}
                    },
                    UserAddress = new SubAddress()
                    {
                        City = "Fairfax",
                        State = "VA",
                        Country = "USA"
                    }

                },
                new Customer { Id = 3, FirstName = "Lionel", LastName = "Messi", Email = "messi@ymail.com",
                    CustomerOrders = new List<Order>()
                    {
                        new Order{ID=4,OrderAmount=1050,OrderDate = DateTime.Now},
                        new Order{ID=5,OrderAmount=600,OrderDate = DateTime.Now},
                        new Order{ID=7,OrderAmount=750,OrderDate = DateTime.Now},
                        new Order{ID=9,OrderAmount=4000,OrderDate = DateTime.Now}
                    },
                    UserAddress = new SubAddress()
                    {
                        City = "Reston",
                        State = "VA",
                        Country = "USA"
                    }

                }
            };
        
            return results;
        }

    }
}
