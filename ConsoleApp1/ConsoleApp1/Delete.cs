using ConsoleApp1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Delete : IDelete
    {
        private int _id = Data.GetUserId();
        public void DeleteUserTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var user = db.Users.Find(_id);
                if (user != null)
                {
                    db.Users.Remove(user);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!");
                }
                db.SaveChanges();
            }
        }
        public void DeleteAwardTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var award = db.Awards.Find(_id);
                if (award != null)
                {
                    db.Awards.Remove(award);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!");
                }
                db.SaveChanges();
            }
        }
        public void DeleteCommentTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var comment = db.Comments.Find(_id);
                if (comment != null)
                {
                    db.Comments.Remove(comment);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!");
                }
                db.SaveChanges();
            }
        }
        public void DeleteCategoryTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var category = db.Categories.Find(_id);
                if (category != null)
                {
                    db.Categories.Remove(category);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!");
                }
                db.SaveChanges();
            }
        }
        public void DeleteLikeTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var like = db.Likes.Find(_id);
                if (like != null)
                {
                    db.Likes.Remove(like);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!");
                }
                db.SaveChanges();
            }
        }
    }
}
