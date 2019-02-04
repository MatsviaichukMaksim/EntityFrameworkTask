using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Read : IRead
    {

        public void ReadUserTable()
        {
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
                    Console.WriteLine($"{award.Id.ToString()}, {award.Title}, {award.Giver}, {award.Getter}, {award.Date.ToString()}, {award.Points}");//GiverId,GetterId
                }
            }
        }
        public void ReadCommentTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Comment comment in db.Comments)
                {
                    Console.WriteLine($"{comment.Id.ToString()}, {comment.Text}, {comment.AwardId}, {comment.UserId}, {comment.Date.ToString()}");
                }
            }
        }
        public void ReadCategoryTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Category category in db.Categories)
                {
                    Console.WriteLine($"{category.Id.ToString()}, {category.Title}, {category.Points}, {category.Date.ToString()}");
                }
            }
        }
        public void ReadLikeTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Like like in db.Likes)
                {
                    Console.WriteLine($"{like.Date.ToString()}, {like.Award}, {like.User}");//AwardId,UserId
                }
            }
        }
    }
}
