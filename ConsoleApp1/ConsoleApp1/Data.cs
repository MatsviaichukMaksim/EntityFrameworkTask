using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Data : IData
    {
        //private int _id = 0;
        public void GetData(User user)
        {
            Console.WriteLine("Enter First Name: ");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            user.Email = Console.ReadLine();
            Console.WriteLine("Enter Phone: ");
            user.Phone = Console.ReadLine();
        }
        public void GetData(Award award)
        {
            Console.WriteLine("Enter id of Giver: ");
            if (int.TryParse(Console.ReadLine(), out int giverId))
            {
                award.AgiverId = giverId;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
            Console.WriteLine("Enter Title of Award: ");
            award.Title = Console.ReadLine();
            Console.WriteLine("Enter id of Getter: ");
            if (int.TryParse(Console.ReadLine(), out int getterId))
            {
                award.AgetterId = getterId;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
            Console.WriteLine("Enter Date: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime myDate))
            {
                award.Date = myDate;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
            Console.WriteLine("Enter id of Category: ");
            if (int.TryParse(Console.ReadLine(), out int categoryId))
            {
                award.CategoryId = categoryId;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
        }
        public void GetData(Category category)
        {
            Console.WriteLine("Enter Title of Category: ");
            category.Title = Console.ReadLine();
            Console.WriteLine("Enter Points by Category: ");
            if (int.TryParse(Console.ReadLine(), out int points))
            {
                category.Points = points;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
            Console.WriteLine("Enter Date: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime myDate))
            {
                category.Date = myDate;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
        }
        public void GetData(Comment comment)
        {
            Console.WriteLine("Enter Text of Comment: ");
            comment.Text = Console.ReadLine();
            Console.WriteLine("Enter id of Award: ");
            if (int.TryParse(Console.ReadLine(), out int awardId))
            {
                comment.AwardId = awardId;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
            Console.WriteLine("Enter id of User: ");
            if (int.TryParse(Console.ReadLine(), out int userId))
            {
                comment.UserId = userId;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
            Console.WriteLine("Enter Date: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime myDate))
            {
                comment.Date = myDate;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
        }
        public void GetData(Like like)
        {
            Console.WriteLine("Enter id of Award: ");
            if (int.TryParse(Console.ReadLine(), out int awardId))
            {
                like.AwardId = awardId;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
            Console.WriteLine("Enter id of User: ");
            if (int.TryParse(Console.ReadLine(), out int userId))
            {
                like.UserId = userId;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
            Console.WriteLine("Enter Date: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime myDate))
            {
                like.Date = myDate;
            }
            else
            {
                Console.WriteLine("Was entered the wrong value");
            }
        }
        public static int GetUserId()
        {
            Console.WriteLine("Enter the id of field: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
            }
            else
            {
                Console.WriteLine("Was entered the wrong Id");
            }
            return id;
        }
        //private void GetDataById()
        //{
        //    using (UserDbContext db = new UserDbContext<T>())
        //    {
        //        var obj = db.Users.Find(_id); //Users?
        //        if (obj != null)
        //        {
        //            GetData(obj);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Was entered the wrong id!");
        //        }
        //        db.SaveChanges();
        //    }
        //}

    }
}
