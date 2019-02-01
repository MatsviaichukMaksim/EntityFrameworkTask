using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AddValue:User,IAddValue
    {
        public void AddUserTable()
        {
            //User user = new User() { Id=5,FirstName = "Artem", LastName ="Sergeev",Email="ads",Phone="dasdas" };
            using (UserDbContext db = new UserDbContext())
            {
                User user = new User() { FirstName = "Artem", LastName = "Sergeev", Email = "ads", Phone = "dasdas" };
                db.Users.Add(user);
                db.SaveChanges();

            }
        }
        public void AddAwardTable()
        {
            using (UserDbContext db = new UserDbContext())
            {

            }
        }
        public void AddCommentTable()
        {
            using (UserDbContext db = new UserDbContext())
            {

            }
        }
        public void AddCategoryTable()
        {
            using (UserDbContext db = new UserDbContext())
            {

            }
        }
        public void AddLikeTable()
        {
            using (UserDbContext db = new UserDbContext())
            {

            }
        }
        private void GetUser()
        {
            
        }
    }
}
