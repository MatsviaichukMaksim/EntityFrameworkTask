using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UserDbContext())
            {
                var user = new User() { FirstName = "Vasya", LastName ="Ivanov",Email="asdadsasd",Phone="asdasd" };
            }
        }
    }
}
