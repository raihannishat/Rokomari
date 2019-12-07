﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Rokomari
{
    public class Update
    {
        private const string _ConnectionString = "Server = DESKTOP-P2EDQU6; Database = Rokomari; Trusted_Connection = true;";
        private string _QueryString = null;

        public void Update_Book(Books Book)
        {
            _QueryString = " UPDATE Books " +
                           " SET " +
                           "     Book_Name = @Book_Name, " +
                           "     Book_Author = @Book_Author, " +
                           "     Book_Price = @Book_Price, " +
                           "     Book_Stock = @Book_Stock " +
                           " WHERE Book_ID = @BooK_ID; ";

            using SqlConnection Connection = new SqlConnection(_ConnectionString);
            using SqlCommand Command = new SqlCommand(_QueryString, Connection);

            SqlParameter Book_ID_Para = new SqlParameter("@Book_ID", SqlDbType.Int);
            Book_ID_Para.Value = Book.Book_ID;
            Command.Parameters.Add(Book_ID_Para);

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

            Connection.Open();
            Command.ExecuteNonQuery();
        }
    }
}