using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IInformation
    {
        string TableName { get; set; }
        string ActionUser { get; set; }
        void GetTableNameAndAction();
    }
}
