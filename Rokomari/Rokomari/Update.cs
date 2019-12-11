using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Rokomari
{
    public class Update : Connection
    {
        public void Update_Book(Books Book)
        {
            _QueryString = " UPDATE Books " +
                           " SET " +
                           "     Book_Name = @Book_Name, " +
                           "     Book_Author = @Book_Author, " +
                           "     Book_Price = @Book_Price " +
                           " WHERE Book_ID = @BooK_ID; ";

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
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

                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
            }     
        }

        public void Update_Customer(Customers Customer)
        {
            _QueryString = " UPDATE Customers " +
                           " SET " +
                           "    Customer_Name = @Customer_Name, " +
                           "    Customer_Address = @Customer_Address " +
                           " WHERE Customer_ID = @Customer_ID; ";

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
                    SqlParameter Customer_ID_Para = new SqlParameter("@Customer_ID", SqlDbType.Int);
                    Customer_ID_Para.Value = Customer.Customer_ID;
                    Command.Parameters.Add(Customer_ID_Para);

                    SqlParameter Customer_Name_Para = new SqlParameter("@Customer_Name", SqlDbType.VarChar);
                    Customer_Name_Para.Value = Customer.Customer_Name;
                    Command.Parameters.Add(Customer_Name_Para);

                    SqlParameter Customer_Address_Para = new SqlParameter("@Customer_Address", SqlDbType.VarChar);
                    Customer_Address_Para.Value = Customer.Customer_Address;
                    Command.Parameters.Add(Customer_Address_Para);

                    Connection.Open();
                    Command.ExecuteNonQuery();
                }
            }
        }

        public void Update_Order(int Order_ID, int Book_ID, int Customer_ID)
        {
            _QueryString = " UPDATE Orders " +
                           " SET " +
                           "    Book_ID = @Book_ID," +
                           "    Customer_ID = @Customer_ID" +
                           " WHERE Order_ID = @Order_ID; ";

            using (SqlConnection Connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand(_QueryString, Connection))
                {
                    SqlParameter Order_ID_Para = new SqlParameter("@Order_ID", SqlDbType.Int);
                    Order_ID_Para.Value = Order_ID;
                    Command.Parameters.Add(Order_ID_Para);

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
    }
}
