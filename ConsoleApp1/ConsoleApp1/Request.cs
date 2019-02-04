using ConsoleApp1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Request : IRequest
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;

        public void SearchAwards()
        {
            Console.WriteLine("Enter the name of category: ");
            string titleOfCategory = Console.ReadLine();
            using (UserDbContext db = new UserDbContext())
            {
                var answer = db.Awards
                    .Where(a => a.Category.Title.Contains(titleOfCategory, StringComparison.OrdinalIgnoreCase)); //Include??
                if (answer != null)
                {
                    foreach (var award in answer)
                    {
                        Console.WriteLine($"Award: {award.Title}");
                    }
                }
                else
                {
                    Console.WriteLine("Wasn't found!");
                }
            }
        }
        public void CalculateAveragePoints()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var answer = db.Awards.Average(a => a.Points);
                Console.WriteLine($"Average points by Award:{answer}");
            }
        }
        public void SearchAwardsByGiver()
        {
            using (UserDbContext db = new UserDbContext())
            {
                GetUserName();
                var answer = db.Awards
                    .Where(u => u.Giver.FirstName == _firstName && u.Giver.LastName == _lastName);
                if (answer != null)
                {
                    foreach (var award in answer)
                    {
                        Console.WriteLine($"Award:{award.Title}");
                    }
                }
                else
                {
                    Console.WriteLine("Wasn't found!");
                }
            }
        }
        public void CalculateAveragePointsGivenByUser()
        {
            using (UserDbContext db = new UserDbContext())
            {
                GetUserName();
                var answer = db.Awards
                    .Where(u => u.Giver.FirstName == _firstName && u.Giver.LastName == _lastName).Average(u => u.Points);
                if (answer != null)
                {
                        Console.WriteLine($"Points: {answer}");  // for every person??
                }
                else
                {
                    Console.WriteLine("Wasn't found!");
                }
            }

        }
        public void MostPopularAward()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var answer = db.Awards.GroupBy(q => q.Category).OrderByDescending(ct => ct.Count()).Take(1)
                    .Select(a => a.Key).FirstOrDefault();
                if (answer != null)
                {
                    Console.WriteLine($"Title: { answer.Title}");
                }
                else
                {
                    Console.WriteLine("Wasn't found!");
                }
            }
        }
        private void GetUserName()
        {
            Console.WriteLine("Enter First Name:");
            _firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            _lastName = Console.ReadLine();

        }
    }
}
