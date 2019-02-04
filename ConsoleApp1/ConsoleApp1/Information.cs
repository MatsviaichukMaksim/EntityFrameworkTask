using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Information : IInformation
    {
        public string TableName { get; private set; }
        public string ActionUser { get; private set; }
        public string RequestName { get; private set; }
        public string Answer { get; private set; }

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
        private void GetRequestName()
        {
            Console.WriteLine("Write request:");
            RequestName = Console.ReadLine();
        }
        public void GetTableNameAndAction()
        {
            Console.WriteLine("Do you want to work 1: with table or 2: requests? ");
            Answer = Console.ReadLine();
            if (Answer == "1")
            {
                ActionFromUser();
                TableNameFromUser();
            }
            else if (Answer == "2")
            {
                GetRequestName();
            }
            else
            {
                Console.WriteLine("Was entered wrong value!");
            }

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
