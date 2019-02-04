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
                    Console.WriteLine($"Id:{award.Id.ToString()}, Title: {award.Title}, Giver: {award.Giver}, Getter: {award.Getter}, Date:{award.Date.ToString()}, Points: {award.Points}");//GiverId,GetterId???
                    //award.GiverId.FirstName
                }
            }
        }
        public void ReadCommentTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Comment comment in db.Comments)
                {
                    Console.WriteLine($"Id: {comment.Id.ToString()}, Text: {comment.Text}, AwardId: {comment.AwardId}, UserId: {comment.UserId}, Date: {comment.Date.ToString()}");
                }
            }
        }
        public void ReadCategoryTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Category category in db.Categories)
                {
                    Console.WriteLine($"Id: {category.Id.ToString()}, Title: {category.Title}, Category: {category.Points}, Date: {category.Date.ToString()}");
                }
            }
        }
        public void ReadLikeTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                foreach (Like like in db.Likes)
                {
                    Console.WriteLine($"Date: {like.Date.ToString()}, AwardId:{like.AwardId}, UserId:{like.UserId}");//AwardId,UserId
                }
            }
        }
    }
}
