using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AddValue : IAddValue
    {
        public void AddUserTable()
        {
            //User user = new User() { Id=5,FirstName = "Artem", LastName ="Sergeev",Email="ads",Phone="dasdas" };
            using (UserDbContext db = new UserDbContext())
            {
                Data data = new Data();
                User user = new User();
                data.GetData(user);
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public void AddAwardTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                Data data = new Data();
                Award award = new Award();
                data.GetData(award);
                db.Awards.Add(award);
                db.SaveChanges();
            }
        }
        public void AddCommentTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                Data data = new Data();
                Comment comment = new Comment();
                data.GetData(comment);
                db.Comments.Add(comment);
                db.SaveChanges();
            }
        }
        public void AddCategoryTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                Data data = new Data();
                Category category = new Category();
                data.GetData(category);
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }
        public void AddLikeTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                Data data = new Data();
                Like like = new Like();
                data.GetData(like);
                db.Likes.Add(like);
                db.SaveChanges();
            }
        }
    }
}
