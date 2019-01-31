using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IAction
    {
        void LaunchAction(string action,string tableName);
    }
}
