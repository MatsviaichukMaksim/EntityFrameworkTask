using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Read:IAction
    {
        private UserDbContext _db = new UserDbContext();
        private string _tableName = string.Empty;
        //Read(string readActionUser)
        //{
        //    _storageActionUser = Checking.CheckEnteredString(readActionUser);
        //}
        //private void KnowTableName()
        //{
        //    Console.WriteLine("Enter name of table which you want to see: ");
        //    string _tableName = Checking.CheckEnteredString(Console.ReadLine());
        //}
        public void Action(string forRead)
        {
            if(forRead=="User")
            {
                ReadUserTable();
            }
            else if (forRead == "Award")
            {
                ReadUserTable();
            }
            else if (forRead == "Comment")
            {
                ReadUserTable();
            }
            else if (forRead == "Category")
            {
                ReadUserTable();
            }
            else if (forRead == "Like")
            {
                ReadUserTable();
            }
            else
            {
                Console.WriteLine("Was entered the wrong string");
            }
        }
        
        private void ReadUserTable()
        {
            // Извлечь всех заказчиков и отобразить их имена в консоли
            using (UserDbContext _db = new UserDbContext())
            {
                foreach (User user in _db.Users)
                {
                    Console.WriteLine($"Id:{user.Id.ToString()},First name: {user.FirstName},Last Name: {user.LastName},Email:{user.Email},Phone:{user.Phone}");
                }
            }
        }
        private void ReadAwardTable()
        {
            using (UserDbContext _db = new UserDbContext())
            {
                foreach (Award award in _db.Awards)
                {
                    Console.WriteLine(award.Id.ToString(), award.Giver, award.Getter, award.Date, award.Points);
                }
            }
        }
        private void ReadCommentTable()
        {
            using (UserDbContext _db = new UserDbContext())
            {
                foreach (Comment comment in _db.Comments)
                {
                    Console.WriteLine(comment.Id.ToString(), comment.Text,comment.Award,comment.User,comment.Date);
                }
            }
        }
        private void ReadCategoryTable()
        {
            using (UserDbContext _db = new UserDbContext())
            {
                foreach (Category category in _db.Categories)
                {
                    Console.WriteLine(category.Id.ToString(),category.Title,category.Points,category.Date);
                }
            }
        }
        private void ReadLikeTable()
        {
            using (UserDbContext _db = new UserDbContext())
            {
                foreach (Like like in _db.Likes)
                {
                    Console.WriteLine(like.Date);
                }
            }
        }

    }
}
