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
                int Stock = (int)Reader["Book_Stock"];
                int Sell = (int)Reader["Book_Sell"];
                Book_List.Add(new Books(ID, Name, Author, Price, Stock, Sell));
            }

            ConsoleTable Books_Table = new ConsoleTable("ID", "Name", "Author", "Price", "Stock", "Sell");

            foreach (var item in Book_List)
            {
                Books_Table.AddRow(item.Book_ID, item.Book_Name, item.Book_Author, item.Book_Price, item.Book_Stock, item.Book_Sell);
            }

            Books_Table.Write();
        }
    }
}
