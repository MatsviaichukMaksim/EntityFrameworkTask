using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IUpdate
    {
        void UpdateUserTable();
        void UpdateAwardTable();
        void UpdateCommentTable();
        void UpdateCategoryTable();
        void UpdateLikeTable();
    }
}
