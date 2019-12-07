using System;
using System.Collections.Generic;
using System.Text;

namespace Rokomari
{
    public class Books
    {
        public int Book_ID { get; set; }
        public string Book_Name { get; set; }
        public string Book_Author { get; set; }
        public int Book_Price { get; set; }
        public int Book_Stock { get; set; }
        public int Book_Sell { get; set; }

        public Books(int ID, string Name, string Author, int Price, int Stock)
        {
            Book_ID = ID;
            Book_Name = Name;
            Book_Author = Author;
            Book_Price = Price;
            Book_Stock = Stock;
        }
        public Books(string Name, string Author, int Price, int Stock, int Sell)
        {
            Book_Name = Name;
            Book_Author = Author;
            Book_Price = Price;
            Book_Stock = Stock;
            Book_Sell = Sell;
        }

        public Books(int ID, string Name, string Author, int Price, int Stock, int Sell)
        {
            Book_ID = ID;
            Book_Name = Name;
            Book_Author = Author;
            Book_Price = Price;
            Book_Stock = Stock;
            Book_Sell = Sell;
        }
    }
}
