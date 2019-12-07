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
            _QueryString = " INSERT INTO Books (Book_Name, Book_Author, Book_Price, Book_Stock, Book_Sell) " +
                           " VALUES (@Book_Name, @Book_Author, @Book_Price, @Book_Stock, @Book_Sell); ";

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

            SqlParameter Book_Stock_Para = new SqlParameter("@Book_Stock", SqlDbType.Int);
            Book_Stock_Para.Value = Book.Book_Stock;
            Command.Parameters.Add(Book_Stock_Para);

            SqlParameter Book_Sell_Para = new SqlParameter("@Book_Sell", SqlDbType.Int);
            Book_Sell_Para.Value = Book.Book_Sell;
            Command.Parameters.Add(Book_Sell_Para);

            Connection.Open();
            Command.ExecuteNonQuery();
        }
    }
}
