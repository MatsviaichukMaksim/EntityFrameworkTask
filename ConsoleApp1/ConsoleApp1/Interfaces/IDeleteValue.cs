using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IDeleteValue
    {
        void DeleteUserTable();
        void DeleteAwardTable();
        void DeleteCommentTable();
        void DeleteCategoryTable();
        void DeleteLikeTable();
    }
}
