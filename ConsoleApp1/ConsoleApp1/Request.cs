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
        public void SearchAwards()
        {
            Console.WriteLine("Enter the name of category: ");
            string titleOfCategory = Console.ReadLine();
            using (UserDbContext db = new UserDbContext())
            {
                var response = db.Awards
                    .Where(a => a.Category.Title.Contains(titleOfCategory, StringComparison.OrdinalIgnoreCase))
                    .Include(a => a.AgiverId).Include(a => a.AgetterId)
                    .Include(a => a.Category);
                foreach (var award in response)
                {
                    Console.WriteLine(award.Title);
                }
            }
        }
        public void CalculateAveragePoints()
        {

        }
        public void SearchAwardsByGiver()
        {

        }
        public void CalculateAveragePointsGivenByUser()
        {

        }
        public void MostPopularAward()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var response = db.Awards.GroupBy(q => q.Category).OrderByDescending(ct => ct.Count()).Take(1)
                    .Select(a => a.Key).FirstOrDefault();
                Console.WriteLine(response.Title); //// or response
            }
        }
    }
}
