using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Action : IAction
    {
        //private int _id = 0;
        public void LaunchAction(string action, string tableName)
        {
            action = action.ToLower();
            tableName = tableName.ToLower();
            if (action == "read")
            {
                Read readValue = new Read();
                if (tableName == "user")
                {
                    readValue.ReadUserTable();
                }
                else if (tableName == "award")
                {
                    readValue.ReadAwardTable();
                }
                else if (tableName == "comment")
                {
                    readValue.ReadCommentTable();
                }
                else if (tableName == "category")
                {
                    readValue.ReadCategoryTable();
                }
                else if (tableName == "like")
                {
                    readValue.ReadLikeTable();
                }
                else
                {
                    Console.WriteLine("Was entered the wrong name of the table");
                }
            }
            else if (action == "add")
            {
                AddValue addValue = new AddValue();
                if (tableName == "user")
                {
                    addValue.AddUserTable();
                }
                else if (tableName == "award")
                {
                    addValue.AddAwardTable();
                }
                else if (tableName == "comment")
                {
                    addValue.AddCommentTable();
                }
                else if (tableName == "category")
                {
                    addValue.AddCategoryTable();
                }
                else if (tableName == "like")
                {
                    addValue.AddLikeTable();
                }
                else
                {
                    Console.WriteLine("Was entered the wrong name of the table");
                }
            }
            else if (action == "update")
            {
                Update updateValue = new Update();
                if (tableName == "user")
                {
                    updateValue.UpdateUserTable();
                }
                else if (tableName == "award")
                {
                    updateValue.UpdateAwardTable();
                }
                else if (tableName == "comment")
                {
                    updateValue.UpdateCommentTable();
                }
                else if (tableName == "category")
                {
                    updateValue.UpdateCategoryTable();
                }
                else if (tableName == "like")
                {
                    updateValue.UpdateLikeTable();
                }
                else
                {
                    Console.WriteLine("Was entered the wrong name of the table");
                }
            }
            else if (action == "delete")
            {
                Delete deleteValue = new Delete();
                if (tableName == "user")
                {
                    deleteValue.DeleteUserTable();
                }
                else if (tableName == "award")
                {
                    deleteValue.DeleteAwardTable();
                }
                else if (tableName == "comment")
                {
                    deleteValue.DeleteCommentTable();
                }
                else if (tableName == "category")
                {
                    deleteValue.DeleteCategoryTable();
                }
                else if (tableName == "like")
                {
                    deleteValue.DeleteLikeTable();
                }
                else
                {
                    Console.WriteLine("Was entered the wrong name of the table");
                }
            }
            else
            {
                Console.WriteLine("Was entered the wrong Action");
            }

        }
        public void Request(string requestName)
        {
            Request request = new Request();
            requestName = requestName.ToLower();
            if (requestName == "search_awards")
            {
                request.SearchAwards();
            }
            else if (requestName == "calculate_average_points")
            {
                request.CalculateAveragePoints();
            }
            else if (requestName == "search_awards_by_giver")
            {
                request.SearchAwardsByGiver();
            }
            else if (requestName == "calculate_average_points_given_by_user")
            {
                request.CalculateAveragePointsGivenByUser();
            }
            else if (requestName == "most_popular_award")
            {
                request.MostPopularAward();
            }
            else
            {
                Console.WriteLine("Was entered the wrong request");
            }

        }
        //private void GetUserId()
        //{
        //    Console.WriteLine("Enter the id of field: ");
        //    if (int.TryParse(Console.ReadLine(), out int Id))
        //    {
        //        _id = Id;
        //    }

        //}
    }
}
