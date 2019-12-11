using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConsoleTables;

namespace Rokomari
{
    public class Get_By_Book : Connection
    {
        public void Get_Book_Info(int ID)
        {
            Console.Clear();
            List<Books> Book_Info_List = new List<Books>();

            _QueryString = " SELECT DISTINCT Books.Book_ID, Books.Book_Name, Books.Book_Author, Books.Book_Price " +
                           " FROM Books, Orders " +
                           " WHERE Books.Book_ID = Orders.Book_ID " +
                           " AND Orders.Customer_ID = @Customer_ID; ";

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
                    SqlParameter Customer_ID_Para = new SqlParameter("@Customer_ID", SqlDbType.Int);
                    Customer_ID_Para.Value = ID;
                    Command.Parameters.Add(Customer_ID_Para);

                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            int BID = (int)Reader["Book_ID"];
                            string Name = (string)Reader["Book_Name"];
                            string Author = (string)Reader["Book_Author"];
                            int Price = (int)Reader["Book_Price"];
                            Book_Info_List.Add(new Books(BID, Name, Author, Price));
                        }
                    }
                }
            }

            ConsoleTable Books_Table = new ConsoleTable("ID", "Name", "Author", "Price");

            foreach (var item in Book_Info_List)
            {
                Books_Table.AddRow(item.Book_ID, item.Book_Name, item.Book_Author, item.Book_Price);
            }

            Books_Table.Write();
        }

        public void Get_Customer_Info(int ID)
        {
            Console.Clear();
            List<Customers> Customer_Info_List = new List<Customers>();

            _QueryString = " SELECT DISTINCT Customers.Customer_ID, Customers.Customer_Name, Customers.Customer_Address " +
                           " FROM Customers, Orders " +
                           " WHERE Customers.Customer_ID = Orders.Customer_ID " +
                           " AND Orders.Book_ID = @Book_ID; ";

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
                    SqlParameter Book_ID_Para = new SqlParameter("@Book_ID", SqlDbType.Int);
                    Book_ID_Para.Value = ID;
                    Command.Parameters.Add(Book_ID_Para);

                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            int CID = (int)Reader["Customer_ID"];
                            string Name = (string)Reader["Customer_Name"];
                            string Address = (string)Reader["Customer_Address"];
                            Customer_Info_List.Add(new Customers(CID, Name, Address));
                        }
                    }
                }
            }

            ConsoleTable Books_Table = new ConsoleTable("Customer ID", "Customer Name", "Customer Address");

            foreach (var item in Customer_Info_List)
            {
                Books_Table.AddRow(item.Customer_ID, item.Customer_Name, item.Customer_Address);
            }

            Books_Table.Write();
        }

        public Books Get_Book(int ID)
        {
            Books Book = null;
            _QueryString = " SELECT * FROM Books WHERE Book_ID = @Book_ID; ";

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
                    SqlParameter Book_ID_Para = new SqlParameter("@Book_ID", SqlDbType.Int);
                    Book_ID_Para.Value = ID;
                    Command.Parameters.Add(Book_ID_Para);

                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            int BID = (int)Reader["Book_ID"];
                            string Name = (string)Reader["Book_Name"];
                            string Author = (string)Reader["Book_Author"];
                            int Price = (int)Reader["Book_Price"];
                            Book = new Books(BID, Name, Author, Price);
                            break;
                        }
                    }
                }
            }

            return Book;
        }

        public Customers Get_Customer(int ID)
        {
            Customers Customer = null;

            _QueryString = " SELECT * FROM Customers WHERE Customer_ID = @Customer_ID; ";

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
                    SqlParameter Customer_ID_Para = new SqlParameter("@Customer_ID", SqlDbType.Int);
                    Customer_ID_Para.Value = ID;
                    Command.Parameters.Add(Customer_ID_Para);

                    Connection.Open();
                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            int CID = (int)Reader["Customer_ID"];
                            string Name = (string)Reader["Customer_Name"];
                            string Address = (string)Reader["Customer_Address"];
                            Customer = new Customers(CID, Name, Address);
                            break;
                        }
                    }
                }
            }

            return Customer;
        }
    }
}
