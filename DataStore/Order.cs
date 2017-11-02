using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
   public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderAmount { get; set; }
        public Customer OrderCustomer { get; set; }
    }
}
