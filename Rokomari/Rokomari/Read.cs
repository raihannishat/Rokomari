using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ConsoleTables;

namespace Rokomari
{
    public class Read
    {
        private const string _ConnectionString = "Server = DESKTOP-P2EDQU6; Database = Rokomari; Trusted_Connection = true;";
        private string _QueryString = null;

        public void Read_Books()
        {
            List<Books> Book_List = new List<Books>();

            _QueryString = " SELECT * FROM Books; ";

            using SqlConnection Connection = new SqlConnection(_ConnectionString);
            using SqlCommand Command = new SqlCommand(_QueryString, Connection);

            Connection.Open();
            using SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int ID = (int)Reader["Book_ID"];
                string Name = (string)Reader["Book_Name"];
                string Author = (string)Reader["Book_Author"];
                int Price = (int)Reader["Book_Price"];
                Book_List.Add(new Books(ID, Name, Author, Price));
            }

            ConsoleTable Books_Table = new ConsoleTable("ID", "Name", "Author", "Price");

            foreach (var item in Book_List)
            {
                Books_Table.AddRow(item.Book_ID, item.Book_Name, item.Book_Author, item.Book_Price);
            }

            Books_Table.Write();
        }

        public void Read_Customers()
        {
            List<Customers> Customer_List = new List<Customers>();

            _QueryString = " SELECT * FROM Customers; ";

            using SqlConnection Connection = new SqlConnection(_ConnectionString);
            using SqlCommand Command = new SqlCommand(_QueryString, Connection);

            Connection.Open();
            using SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int ID = (int)Reader["Customer_ID"];
                string Name = (string)Reader["Customer_Name"];
                string Address = (string)Reader["Customer_Address"];
                Customer_List.Add(new Customers(ID, Name, Address));
            }

            ConsoleTable Customers_Table = new ConsoleTable("ID", "Name", "Address");

            foreach (var item in Customer_List)
            {
                Customers_Table.AddRow(item.Customer_ID, item.Customer_Name, item.Customer_Address);
            }

            Customers_Table.Write();
        }

        public void Read_Orders()
        {
            List<Orders> Order_List = new List<Orders>();

            _QueryString = " SELECT * FROM Orders; ";

            using SqlConnection Connection = new SqlConnection(_ConnectionString);
            using SqlCommand Command = new SqlCommand(_QueryString, Connection);

            Connection.Open();
            using SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int Order_ID = (int)Reader["Order_ID"];
                int Book_ID = (int)Reader["Book_ID"];
                int Customer_ID = (int)Reader["Customer_ID"];
                Order_List.Add(new Orders(Order_ID, Book_ID, Customer_ID));
            }

            ConsoleTable Orders_Table = new ConsoleTable("Order ID", "Book ID", "Customer ID");

            foreach (var item in Order_List)
            {
                Orders_Table.AddRow(item.Order_ID, item.Book_ID, item.Customer_ID);
            }

            Orders_Table.Write();
        }
    }
}
