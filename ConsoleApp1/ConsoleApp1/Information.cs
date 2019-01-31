using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Information:IInformation
    {
       public string TableName { get; set; }
       public string ActionUser { get; set; }

            private void ActionFromUser()
        {
            Console.WriteLine("Write action:");
            ActionUser = Console.ReadLine();
        }

        private void TableNameFromUser()
        {
            Console.WriteLine("Write table name with you want to work:");
            TableName = Console.ReadLine();
        }
        public void GetTableNameAndAction()
        {
            ActionFromUser();
            TableNameFromUser();
        }
        //public string GetAction()
        //{
        //    ActionFromUser();
        //    return _actionUser;
        //}
        //public string GetTableName()
        //{
        //    TableNameFromUser();
        //    return _tableName;
        //}
    }
}
