using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces
{
    interface IData
    {
        void GetData(User user);
        void GetData(Award award);
        void GetData(Category category);
        void GetData(Comment comment);
        void GetData(Like like);
        //int GetUserId();
    }
}
