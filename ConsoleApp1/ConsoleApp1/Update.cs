﻿using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Update : IUpdate
    {
        private Data data = new Data();
        private int _id = Data.GetUserId();
        public void UpdateUserTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var user = db.Users.Find(_id);
                if (user != null)
                {
                    data.GetData(user);
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
                var award = db.Awards.Find(_id);
                if (award != null)
                {
                    data.GetData(award);
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
                var comment = db.Comments.Find(_id);
                if (comment != null)
                {
                    data.GetData(comment);
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
            using (UserDbContext db = new UserDbContext())
            {
                var category = db.Categories.Find(_id);
                if (category != null)
                {
                    data.GetData(category);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!");
                }
                db.SaveChanges();
            }
        }
        public void UpdateLikeTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                var like = db.Likes.Find(_id);
                if (like != null)
                {
                    data.GetData(like);
                }
                else
                {
                    Console.WriteLine("Was entered the wrong id!");
                }
                db.SaveChanges();
            }
        }
        //private void GetDataById<T>(T obj) where T :class
        //{
        //    if (obj != null)
        //    {
        //        data.GetData(obj);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Was entered the wrong id!");
        //    }
        //}
    }
}
