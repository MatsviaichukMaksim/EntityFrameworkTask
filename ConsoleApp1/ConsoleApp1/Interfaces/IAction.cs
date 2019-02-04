using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces
{
    interface IAction
    {
        void LaunchAction(string action, string tableName);
        void Request(string requestName);
    }
}
