using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class ActionUser 
    {
        private string _storageActionUser = string.Empty;
        public ActionUser(string readActionUser)
        {
            _storageActionUser = Checking.CheckEnteredString(readActionUser);
        }
        private void Read()
        {
            //Console.WriteLine("Enter name of table which you want to see: ");
            //string TableName = Checking.CheckEnteredString(Console.ReadLine());
            //return TableName;
        }
        private void Add()
        {

        }
        private void Update()
        {

        }
        private void Delete()
        {

        }

        //public void ReadConsoleFromUserAndCheck(string readActionUser)
        //{
        //    //readActionUser = Console.ReadLine();
        //    //if (readActionUser == null)
        //    //{
        //    //    Console.WriteLine("You haven't written a command");
        //    //    //throw new NullReferenceException();
        //    //}
        //    StorageActionUser = Checking.CheckEnteredString(readActionUser);
        //}
        public string SeparationUserCommands()
        {
            if (_storageActionUser == ("read"))
            {
                Console.WriteLine("Enter name of table which you want to see: ");
                string TableName = Checking.CheckEnteredString(Console.ReadLine());
                return TableName;
                //Read();
            }
            else if (_storageActionUser == ("add"))
            {
                //Add();
            }
            else if (_storageActionUser == ("update"))
            {
                //Update();
            }
            else if (_storageActionUser == ("delete"))
            {
                //Delete();
            }
            else
            {
                //Console.WriteLine("Was entered the wrong string");
            }
            return null; ////////
        }

    }
}
