using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces
{
    interface IDelete
    {
        void DeleteUserTable();
        void DeleteAwardTable();
        void DeleteCommentTable();
        void DeleteCategoryTable();
        void DeleteLikeTable();
    }
}
