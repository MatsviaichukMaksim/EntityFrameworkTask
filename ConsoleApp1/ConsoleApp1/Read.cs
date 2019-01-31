using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Read:IRead
    {
       
        public void ReadUserTable()
        {
            // Извлечь всех заказчиков и отобразить их имена в консоли
            using (UserDbContext db = new UserDbContext())
            {
                foreach (User user in db.Users)
                {
                    Console.WriteLine($"Id: {user.Id.ToString()}, First name: {user.FirstName}, Last Name: {user.LastName}, Email: {user.Email}, Phone: {user.Phone}");
                }
            }
        }
        public void ReadAwardTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Award award in db.Awards)
                {
                    Console.WriteLine(award.Id.ToString(), award.Giver, award.Getter, award.Date, award.Points);
                }
            }
        }
        public void ReadCommentTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Comment comment in db.Comments)
                {
                    Console.WriteLine(comment.Id.ToString(), comment.Text, comment.Award, comment.User, comment.Date);
                }
            }
        }
        public void ReadCategoryTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Category category in db.Categories)
                {
                    Console.WriteLine(category.Id.ToString(), category.Title, category.Points, category.Date);
                }
            }
        }
        public void ReadLikeTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Like like in db.Likes)
                {
                    Console.WriteLine(like.Date);
                }
            }
        }
    }
}
