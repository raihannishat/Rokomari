using System;
using System.Collections.Generic;
using System.Text;
using ConsoleTables;

namespace Rokomari
{
    public class Database : IDBModel
    {
        public void Book_Menu()
        {
            Console.Clear();
            ConsoleTable Book_Menu_Table = new ConsoleTable("#", "Book Menu Options");
            Book_Menu_Table.AddRow("1", "Create Book");
            Book_Menu_Table.AddRow("2", "Read Book");
            Book_Menu_Table.AddRow("3", "Update Book");
            Book_Menu_Table.AddRow("4", "Delete Book");
            Book_Menu_Table.Write();
        }

        public void Buy_Book()
        {
            Console.Write(" Enter your Book ID: ");
            int Book_ID = int.Parse(Console.ReadLine());

            Console.Write(" Enter your Customer ID: ");
            int Customer_ID = int.Parse(Console.ReadLine());

            new Create().Create_Orders(Book_ID, Customer_ID);
            Console.WriteLine(" Successfully purchased the book");
            Console.ReadKey();
        }

        public void Customer_Menu()
        {
            Console.Clear();
            ConsoleTable Customer_Menu_Table = new ConsoleTable("#", "Customer Options");
            Customer_Menu_Table.AddRow("1", "Create Customer");
            Customer_Menu_Table.AddRow("2", "Read Customer");
            Customer_Menu_Table.AddRow("3", "Update Customer");
            Customer_Menu_Table.AddRow("4", "Delete Customer");
            Customer_Menu_Table.Write();
        }

        public void Delete_Book()
        {
            Console.Clear();
            Console.Write(" Enter Book ID: ");
            int Book_ID = int.Parse(Console.ReadLine());

            new Delete().Delete_Book(Book_ID);
            Console.WriteLine(" Delete Book Successfully");
            Console.ReadKey();
        }

        public void Delete_Customer()
        {
            Console.Clear();
            Console.Write(" Enter Customer ID: ");
            int Customer_ID = int.Parse(Console.ReadLine());

            new Delete().Delete_Customer(Customer_ID);
            Console.WriteLine(" Delete Customer Successfully");
            Console.ReadKey();
        }

        public void Delete_Order()
        {
            Console.Clear();
            Console.Write(" Enter Order ID: ");
            int Order_ID = int.Parse(Console.ReadLine());

            new Delete().Delete_Order(Order_ID);
            Console.WriteLine(" Delete Order Successfully");
            Console.ReadKey();
        }

        public void Insert_Book()
        {
            Console.Clear();
            Console.Write(" Enter Book Name: ");
            string Book_Name = Console.ReadLine();

            Console.Write(" Enter Book Author: ");
            string Book_Author = Console.ReadLine();

            Console.Write(" Enter Book Price: ");
            int Book_Price = int.Parse(Console.ReadLine());

            new Create().Create_Books(new Books(Book_Name, Book_Author, Book_Price));
            Console.WriteLine(" Insert Book Successfully");
            Console.ReadKey();
        }

        public void Insert_Customer()
        {
            Console.Clear();
            Console.Write(" Enter Customer Name: ");
            string Customer_Name = Console.ReadLine();

            Console.Write(" Enter Customer Address: ");
            string Customer_Address = Console.ReadLine();

            new Create().Create_Customer(new Customers(Customer_Name, Customer_Address));
            Console.WriteLine(" Insert Customer Successfully");
            Console.ReadKey();
        }

        public void Insert_Order()
        {
            Console.Clear();
            Console.Write(" Enter Book ID: ");
            int Book_ID = int.Parse(Console.ReadLine());

            Console.Write(" Enter Customer ID: ");
            int Customer_ID = int.Parse(Console.ReadLine());

            new Create().Create_Orders(Book_ID, Customer_ID);
            Console.WriteLine(" Insert Order Successfully");
            Console.ReadKey();
        }

        public void Main_Menu()
        {
            Console.Clear();
            ConsoleTable Main_Menu_Table = new ConsoleTable("#", "Welcome to Rokomari");
            Main_Menu_Table.AddRow("1", "Book Menu Option");
            Main_Menu_Table.AddRow("2", "Customer Menu Option");
            Main_Menu_Table.AddRow("3", "Buy Books in Rokomari");
            Main_Menu_Table.AddRow("4", "Rokomari Book Info");
            Main_Menu_Table.AddRow("5", "Rokomari Customer Info");
            Main_Menu_Table.AddRow("6", "Exit Rokomari");
            Main_Menu_Table.Write();
        }

        public void Select_Book()
        {
            Console.Clear();
            new Read().Read_Books();
            Console.ReadKey();
        }

        public void Select_Customer()
        {
            Console.Clear();
            new Read().Read_Customers();
            Console.ReadKey();
        }

        public void Select_Order()
        {
            Console.Clear();
            new Read().Read_Orders();
            Console.ReadKey();
        }

        public void Update_Book()
        {
            Console.Clear();
            Console.Write(" Enter Book ID: ");
            int Book_ID = int.Parse(Console.ReadLine());

            Console.Write(" Enter Book Name: ");
            string Book_Name = Console.ReadLine();

            Console.Write(" Enter Book Author: ");
            string Book_Author = Console.ReadLine();

            Console.Write(" Enter Book price: ");
            int Book_Price = int.Parse(Console.ReadLine());

            new Update().Update_Book(new Books(Book_ID, Book_Name, Book_Author, Book_Price));
            Console.WriteLine(" Update Book Successfully");
            Console.ReadKey();
        }

        public void Update_Customer()
        {
            Console.Clear();
            Console.Write(" Enter Customer ID: ");
            int Customer_ID = int.Parse(Console.ReadLine());

            Console.Write(" Enter Customer Name: ");
            string Customer_Name = Console.ReadLine();

            Console.Write(" Enter Customer Address: ");
            string Customer_Address = Console.ReadLine();

            new Update().Update_Customer(new Customers(Customer_ID, Customer_Name, Customer_Address));
            Console.WriteLine(" Update Customer Successfully");
            Console.ReadKey();
        }

        public void Update_Order()
        {
            Console.Clear();
            Console.Write(" Enter Order ID: ");
            int Order_ID = int.Parse(Console.ReadLine());

            Console.Write(" Enter Book ID: ");
            int Book_ID = int.Parse(Console.ReadLine());

            Console.Write(" Enter Customer ID: ");
            int Customer_ID = int.Parse(Console.ReadLine());

            new Update().Update_Order(Order_ID, Book_ID, Customer_ID);
            Console.WriteLine(" Update Order Successfully");
            Console.ReadKey();
        }
    }
}
