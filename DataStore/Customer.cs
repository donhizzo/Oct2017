using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
   public class Customer : Base
    {
       public ICollection<Order> CustomerOrders { get; set; }
        public Customer():base()
        {

        }
    }
}
