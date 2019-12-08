using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Rokomari
{
    public class Create
    {
        private const string _ConnectionString = "Server = DESKTOP-P2EDQU6; Database = Rokomari; Trusted_Connection = true;";
        private string _QueryString = null;

        public void Create_Books(Books Book)
        {
            _QueryString = " INSERT INTO Books (Book_Name, Book_Author, Book_Price) " +
                           " VALUES (@Book_Name, @Book_Author, @Book_Price); ";

            using SqlConnection Connection = new SqlConnection(_ConnectionString);
            using SqlCommand Command = new SqlCommand(_QueryString, Connection);

            SqlParameter Book_Name_Para = new SqlParameter("@Book_Name", SqlDbType.VarChar);
            Book_Name_Para.Value = Book.Book_Name;
            Command.Parameters.Add(Book_Name_Para);

            SqlParameter Book_Author_Para = new SqlParameter("@Book_Author", SqlDbType.VarChar);
            Book_Author_Para.Value = Book.Book_Author;
            Command.Parameters.Add(Book_Author_Para);

            SqlParameter Book_Price_Para = new SqlParameter("@Book_Price", SqlDbType.Int);
            Book_Price_Para.Value = Book.Book_Price;
            Command.Parameters.Add(Book_Price_Para);

            Connection.Open();
            Command.ExecuteNonQuery();
        }

        public void Create_Customer(Customers Customer)
        {
            _QueryString = " INSERT INTO Customers (Customer_Name, Customer_Address) " +
                           " VALUES (@Customer_Name, @Customer_Address); ";

            using SqlConnection Connection = new SqlConnection(_ConnectionString);
            using SqlCommand Command = new SqlCommand(_QueryString, Connection);

            SqlParameter Customer_Name_Para = new SqlParameter("@Customer_Name", SqlDbType.VarChar);
            Customer_Name_Para.Value = Customer.Customer_Name;
            Command.Parameters.Add(Customer_Name_Para);

            SqlParameter Customer_Address_Para = new SqlParameter("@Customer_Address", SqlDbType.VarChar);
            Customer_Address_Para.Value = Customer.Customer_Address;
            Command.Parameters.Add(Customer_Address_Para);

            Connection.Open();
            Command.ExecuteNonQuery();
        }

        public void Create_Orders(int Book_ID, int Customer_ID)
        {
            _QueryString = " INSERT INTO Orders (Book_ID, Customer_ID) " +
                           " VALUES (@Book_ID, @Customer_ID); ";

            using SqlConnection Connection = new SqlConnection(_ConnectionString);
            using SqlCommand Command = new SqlCommand(_QueryString, Connection);

            SqlParameter Book_ID_Para = new SqlParameter("@Book_ID", SqlDbType.Int);
            Book_ID_Para.Value = Book_ID;
            Command.Parameters.Add(Book_ID_Para);

            SqlParameter Customer_ID_Para = new SqlParameter("@Customer_ID", SqlDbType.Int);
            Customer_ID_Para.Value = Customer_ID;
            Command.Parameters.Add(Customer_ID_Para);

            Connection.Open();
            Command.ExecuteNonQuery();
        }
    }
}
