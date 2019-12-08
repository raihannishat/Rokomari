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

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
                    SqlParameter Book_ID_Para = new SqlParameter("@Book_ID", SqlDbType.Int);
                    Book_ID_Para.Value = Book_ID;
                    Command.Parameters.Add(Book_ID_Para);

                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
            }
        }

        public void Delete_Customer(int Customer_ID)
        {
            _QueryString = " DELETE FROM Customers WHERE Customer_ID = @Customer_ID; ";

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
                    SqlParameter Customer_ID_Para = new SqlParameter("@Customer_ID", SqlDbType.Int);
                    Customer_ID_Para.Value = Customer_ID;
                    Command.Parameters.Add(Customer_ID_Para);

                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
            }
        }

        public void Delete_Order(int Order_ID)
        {
            _QueryString = " DELETE FROM Order WHERE Order_ID = @Order_ID; ";

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
                    SqlParameter Order_ID_Para = new SqlParameter("@Order_ID", SqlDbType.Int);
                    Order_ID_Para.Value = Order_ID;
                    Command.Parameters.Add(Order_ID_Para);

                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
            }
        }
    }
}
