using System;
using TestApp.DataHelper;
using DataStore;
using System.Linq;
using System.Collections.Generic;


namespace DataManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing();
            TestJoin();
            AnotherJoin();
            Groupjoin();
            Console.Read();
        }
        public static IEnumerable<Employee> emp = EmployeeDataGenerator.GetEmployee();
        public static IEnumerable<Customer> cust = CustomerDataGenerator.GetCustomer();
        static void Testing()//Retrieving data from EmployeeDataGenerator using linq
        {
            var retemp = from test in emp
                         where test.FirstName.Contains("o")
                         select test;
            foreach (var i in retemp)
            {
                
                Console.WriteLine("{0}" + " " + "{1}",i.FirstName, i.LastName);
                
            }
            Console.WriteLine("");
        }
        static void TestJoin()//testing the join in linq
        {
            var combine = from comb in emp
                          where comb.Id.Equals(3)
                          join comb2 in cust on comb.Id
                          equals comb2.Id
                          select comb;

            foreach (var i in combine)
            {

                Console.WriteLine("{0}" + " " + "{1}" + "," + "{2}", i.FirstName, i.LastName, i.UserAddress.City);
                
            }
            Console.WriteLine("");
        }
        static void AnotherJoin()
        {
            var combine2 = from comb in emp
                           where comb.Id.Equals(1)
                           join comb2 in cust on comb.Id
                           equals comb2.Id
                           select new
                           {
                               e = comb.FirstName,
                               c = comb2.Email
                           };
            foreach (var i in combine2)
            {
                Console.WriteLine("{0}" + "," + " "  + "{1}", i.e, i.c);
                

            }
            Console.WriteLine("");
        }//more advnaced inner join 
        static void Groupjoin()
        {
            var gj = from comb in emp
                     where comb.Id.Equals(2)
                     join cus in cust on comb.Id
                     equals cus.Id into ordergroup
                     select new
                     {
                         customer = (comb.FirstName + " " + comb.LastName),
                         custid  = comb.Id,
                         myorders = from order1 in ordergroup
                                    select order1.CustomerOrders
                     };
            foreach (var ordergroup in gj)
            {
                Console.WriteLine("{0} with ID number {1}",ordergroup.customer, ordergroup.custid);
                foreach (var theorder in ordergroup.myorders)
                {
                    var neworder = from ord in theorder
                                   select new
                                   {
                                       oid = ord.ID,
                                       oamt = ord.OrderAmount,
                                       odate = ord.OrderDate
                                   };
                    foreach (var i in neworder)
                    {
                        Console.WriteLine("{0}" + ":" + "{1}" + ":"+ "{2}", i.oid, i.oamt, i.odate);
                    }
                }
                    
            }



        }//complex join - working with group join && combining 2 linq queries 
            
    }
}
