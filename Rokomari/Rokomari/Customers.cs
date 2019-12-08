using System;
using System.Collections.Generic;
using System.Text;

namespace Rokomari
{
    public class Customers
    {
        public int Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Address { get; set; }

        public Customers(string Name, string Address)
        {
            Customer_Name = Name;
            Customer_Address = Address;
        }

        public Customers(int ID, string Name, string Address)
        {
            Customer_ID = ID;
            Customer_Name = Name;
            Customer_Address = Address;
        }
    }
}
