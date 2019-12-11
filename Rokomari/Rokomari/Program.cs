using System;

namespace Rokomari
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBModel Rokomari = new Database();
            
            while (true)
            {
                Rokomari.Main_Menu();

                Console.Write("Choose an Option: ");
                int Option = 0;

                try
                {
                    Option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" String is not valid\n");
                }

                if (Option == 1)
                {
                    Rokomari.Book_Menu();

                    Console.Write("Choose an Option: ");
                    int Book_Option = int.Parse(Console.ReadLine());

                    if (Book_Option == 1)
                    {
                        Rokomari.Insert_Book();
                    }
                    else if (Book_Option == 2)
                    {
                        Rokomari.Select_Book();
                    }
                    else if (Book_Option == 3)
                    {
                        Rokomari.Update_Book();
                    }
                }
                else if (Option == 2)
                {
                    Rokomari.Customer_Menu();

                    Console.Write("Choose an Option: ");
                    int Customer_Option = int.Parse(Console.ReadLine());

                    if (Customer_Option == 1)
                    {
                        Rokomari.Insert_Customer();
                    }
                    else if (Customer_Option == 2)
                    {
                        Rokomari.Select_Customer();
                    }
                    else if (Customer_Option == 3)
                    {
                        Rokomari.Update_Customer();
                    }
                }
                else if (Option == 3)
                {
                    Console.Clear();
                    new Read().Read_Books();
                    Rokomari.Buy_Book();
                }
                else if (Option == 4)
                {
                    Rokomari.Book_Info();
                }
                else if (Option == 5)
                {
                    Rokomari.Customer_Info();
                }
                else if (Option == 6)
                {
                    Rokomari.Select_Order();
                }
                else if (Option == 7)
                {
                    Rokomari.About();
                }
                else if (Option == 8)
                {
                    Environment.Exit(0);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
