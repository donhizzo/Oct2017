using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
  public  class Base
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }

        public SubAddress UserAddress { get; set; }
        protected Base()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            CellPhone = string.Empty;
            UserAddress = new SubAddress();
        }
    }
}
