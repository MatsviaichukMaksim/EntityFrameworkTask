using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Update:IUpdate
    {
        private int _id = 0;
        public void UpdateUserTable()
        {
            using (UserDbContext db = new UserDbContext())
            {
                GetUserId();
                //User user = new User() { FirstName = "Artem", LastName = "Sergeev", Email = "ads", Phone = "dasdas" };
                var user = db.Users
            .Where(u => u.Id == _id)
            .FirstOrDefault();
                db.SaveChanges();
            }
        }
        public void UpdateAwardTable()
        {
            GetUserId();
        }
        public void UpdateCommentTable()
        {
            GetUserId();
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
    }
}
