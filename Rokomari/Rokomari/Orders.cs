using System;
using System.Collections.Generic;
using System.Text;

namespace Rokomari
{
    public class Orders
    {
        public int Order_ID { get; set; }
        public int Book_ID { get; set; }
        public int Customer_ID { get; set; }

        public Orders(int Book_ID, int Customer_ID)
        {
            this.Book_ID = Book_ID;
            this.Customer_ID = Customer_ID;
        }

        public Orders(int Order_ID, int Book_ID, int Customer_ID)
        {
            this.Order_ID = Order_ID;
            this.Book_ID = Book_ID;
            this.Customer_ID = Customer_ID;
        }
    }
}
