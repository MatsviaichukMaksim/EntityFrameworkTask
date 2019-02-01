using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Update<T>:IUpdate
    {
        private int _id = 0;
        public void UpdateUserTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                GetUserId();                //User user = new User() { FirstName = "Artem", LastName = "Sergeev", Email = "ads", Phone = "dasdas" };
            //    var user = db.Users
            //.Where(u => u.Id == _id)
            //.FirstOrDefault();
                var user = db.Users.Find(_id);
                if (user != null)
                {
                    ChangeUser(user);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!"); 
                }
                db.SaveChanges();
            }
        }
        public void UpdateAwardTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                GetUserId();
                var award = db.Awards.Find(_id);
                if (award != null)
                {
                    ChangeAward(award);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!");
                }
                db.SaveChanges();
            }
        }
        public void UpdateCommentTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                GetUserId();
                var comment = db.Comments.Find(_id);
                if (comment != null)
                {
                    ChangeComment(comment);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!");
                }
                db.SaveChanges();
            }
        }
        public void UpdateCategoryTable()
        {
            GetUserId();
        }
        public void UpdateLikeTable()
        {
            GetUserId();
        }
        private void GetUserId()
        {
           Console.WriteLine("Enter the id of field: ");
           if (int.TryParse(Console.ReadLine(),out int Id))
            {
                _id = Id;
            }

        }
        //private void GetDataById(T obj)
        //{
        //    using (UserDbContext db = new UserDbContext())
        //    {
        //        var obj = db.Users.Find(_id);
        //        if (user != null)
        //        {
        //            ChangeUser(obj);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Was entered the wrong id!");
        //        }
        //        db.SaveChanges();
        //    }
        //}
        private void ChangeUser(User user)
        {
            Console.WriteLine("Enter First Name:");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            user.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone:");
            user.Phone = Console.ReadLine();
        }
        private void ChangeAward(Award award)
        {
            Console.WriteLine("Enter id of Giver:");
            if (int.TryParse(Console.ReadLine(), out int giverId))
            {
                award.GiverId = giverId;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
            Console.WriteLine("Enter id of Getter:");
            if (int.TryParse(Console.ReadLine(), out int getterId))
            {
                award.GetterId = getterId;
            }
            Console.WriteLine("Enter Date:");
            if (DateTime.TryParse(Console.ReadLine(),out DateTime myDate))
            {
                award.Date = myDate;
            }
            Console.WriteLine("Enter id of Category:");
            if (int.TryParse(Console.ReadLine(), out int categoryId))
            {
                award.CategoryId = categoryId;
            }
        }
        private void ChangeCategory(Category category)
        {
        Console.WriteLine("Enter Title of Category:");
        category.Title = Console.ReadLine();
            ////
    }
        private void ChangeComment(Comment comment)
        {

        }
        private void ChangeLike(Like like)
        {

        }

    }
}
