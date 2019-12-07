using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Rokomari
{
    public class Delete
    {
        private const string _ConnectionString = "Server = DESKTOP-P2EDQU6; Database = Rokomari; Trusted_Connection = true;";
        private string _QueryString = null;

        public void Delete_Book(int Book_ID)
        {
            _QueryString = " DELETE FROM Books WHERE Book_ID = @Book_ID; ";

            using SqlConnection Connection = new SqlConnection(_ConnectionString);
            using SqlCommand Command = new SqlCommand(_QueryString, Connection);

            SqlParameter Book_ID_Para = new SqlParameter("@Book_ID", SqlDbType.Int);
            Book_ID_Para.Value = Book_ID;
            Command.Parameters.Add(Book_ID_Para);

            Connection.Open();
            Command.ExecuteNonQuery();
        }
    }
}
