using System;
using System.Collections.Generic;
using System.Text;

namespace Rokomari
{
    public interface IDBModel
    {
        void Buy_Book();
        void Insert_Book();
        void Select_Book();
        void Update_Book();
        void Delete_Book();
        void Insert_Customer();
        void Select_Customer();
        void Update_Customer();
        void Delete_Customer();
        void Insert_Order();
        void Select_Order();
        void Update_Order();
        void Delete_Order();
        void Main_Menu();
        void Book_Menu();
        void Customer_Menu();
    }
}
