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

        public Books(int ID, string Name, string Author, int Price)
        {
            Book_ID = ID;
            Book_Name = Name;
            Book_Author = Author;
            Book_Price = Price;
        }
        public Books(string Name, string Author, int Price)
        {
            Book_Name = Name;
            Book_Author = Author;
            Book_Price = Price;
        }
    }
}
