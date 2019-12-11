using System;
using System.Collections.Generic;
using System.Text;
using ConsoleTables;
using Figgle;

namespace Rokomari
{
    public class Database : IDBModel
    {
        public void About()
        {
            Console.Clear();
            Console.WriteLine(FiggleFonts.Standard.Render("Rokomari"));
            Console.WriteLine("   Name: Raihan Nishat");
            Console.WriteLine("   ID: 182-35-2518");
            Console.WriteLine("   Subject: Object Oriented Design (SE 221)");
            Console.WriteLine("   Batch: 26 and Sec: A");
            Console.WriteLine("   Department of Software Engineering (SWE)");
            Console.WriteLine("   Daffodil International University (DIU)");
            Console.ReadKey();
        }

        public void Book_Info()
        {
            Console.Clear();
            new Read().Read_Books();
            Console.Write(" Enter your Book ID: ");
            int Book_ID = 0;

            try
            {
                Book_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            new Get_By_Book().Get_Customer_Info(Book_ID);
            Console.ReadKey();
        }

        public void Book_Menu()
        {
            Console.Clear();
            ConsoleTable Book_Menu_Table = new ConsoleTable("#", "Book Menu Options");
            Book_Menu_Table.AddRow("1", "Create Book");
            Book_Menu_Table.AddRow("2", "Read Book");
            Book_Menu_Table.AddRow("3", "Update Book");
            Book_Menu_Table.Write();
        }

        public void Buy_Book()
        {
            Console.Write(" Enter your Book ID: ");
            int Book_ID = 0;

            try
            {
                Book_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            Console.Write(" Enter your Customer ID: ");
            int Customer_ID = 0;

            try
            {
                Customer_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            if (new Get_By_Book().Get_Book(Book_ID) != null && new Get_By_Book().Get_Customer(Customer_ID) != null)
            {
                new Create().Create_Orders(Book_ID, Customer_ID);
                Console.WriteLine(" Successfully purchased the book");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" Book_ID or Customer_ID invalid.");
            }
        }

        public void Customer_Info()
        {
            Console.Clear();
            new Read().Read_Customers();
            Console.Write(" Enter your Customer ID: ");
            int Customer_ID = 0;

            try
            {
                Customer_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            new Get_By_Book().Get_Book_Info(Customer_ID);
            Console.ReadKey();
        }

        public void Customer_Menu()
        {
            Console.Clear();
            ConsoleTable Customer_Menu_Table = new ConsoleTable("#", "Customer Options");
            Customer_Menu_Table.AddRow("1", "Create Customer");
            Customer_Menu_Table.AddRow("2", "Read Customer");
            Customer_Menu_Table.AddRow("3", "Update Customer");
            Customer_Menu_Table.Write();
        }

        public void Delete_Book()
        {
            Console.Clear();
            Console.Write(" Enter Book ID: ");
            int Book_ID = 0;

            try
            {
                Book_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            if (new Get_By_Book().Get_Book(Book_ID) != null)
            {
                new Delete().Delete_Book(Book_ID);
                Console.WriteLine(" Delete Book Successfully");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(" Book not found.");
            }      
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
            int Book_Price = 0;

            try
            {
                Book_Price = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

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
            int Book_ID = 0;

            try
            {
                Book_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            Console.Write(" Enter Customer ID: ");
            int Customer_ID = 0;

            try
            {
                Customer_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

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
            Main_Menu_Table.AddRow("6", "Rokomari Orders List");
            Main_Menu_Table.AddRow("7", "About Rokomari");
            Main_Menu_Table.AddRow("8", "Exit Rokomari");
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
            int Book_ID = 0;

            try
            {
                Book_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            Console.Write(" Enter Book Name: ");
            string Book_Name = Console.ReadLine();

            Console.Write(" Enter Book Author: ");
            string Book_Author = Console.ReadLine();

            Console.Write(" Enter Book price: ");
            int Book_Price = 0;

            try
            {
                Book_Price = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            new Update().Update_Book(new Books(Book_ID, Book_Name, Book_Author, Book_Price));
            Console.WriteLine(" Update Book Successfully");
            Console.ReadKey();
        }

        public void Update_Customer()
        {
            Console.Clear();
            Console.Write(" Enter Customer ID: ");
            int Customer_ID = 0;

            try
            {
                Customer_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

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
            int Order_ID = 0;

            try
            {
                Order_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            Console.Write(" Enter Book ID: ");
            int Book_ID = 0;

            try
            {
                Book_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            Console.Write(" Enter Customer ID: ");
            int Customer_ID = 0;

            try
            {
                Customer_ID = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine(" String is not valid\n");
            }

            new Update().Update_Order(Order_ID, Book_ID, Customer_ID);
            Console.WriteLine(" Update Order Successfully");
            Console.ReadKey();
        }
    }
}
