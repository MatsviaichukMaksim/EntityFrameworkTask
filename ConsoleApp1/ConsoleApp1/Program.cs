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
            Information information = new Information();
            information.GetTableNameAndAction();
            Action action = new Action();
            action.LaunchAction(information.ActionUser, information.TableName);
        }
    }
}
