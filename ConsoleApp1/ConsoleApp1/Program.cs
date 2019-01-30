using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
       // ReadFromConsole = Console.Readline();
            //ActionUser action = new ActionUser();
        static void Main(string[] args)
        {
            //string nameAction = Console.ReadLine();
            using (var db = new UserDbContext())
            {
                var user = new User() { FirstName = "Vasya", LastName ="Ivanov",Email="asdadsasd",Phone="asdasd" };
            }
            //public string ReadFromConsole;
            string nameAction = Console.ReadLine();
            ActionUser action = new ActionUser(nameAction);
            string tableName = action.SeparationUserCommands();
            Read reader = new Read();
            reader.Action(tableName);
            //Console.WriteLine("Enter name of table which you want to see: ");
            //string tableName = Checking.CheckEnteredString(Console.ReadLine());
        }
    }
}
