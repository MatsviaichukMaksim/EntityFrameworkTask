using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Action:IAction
    {
        public void LaunchAction(string Action, string tableName)
        {
            if (Action == "read")
            {
                Read readValue = new Read();
                if (tableName == "User")
                {
                    readValue.ReadUserTable();
                }
                else if (tableName == "Award")
                {
                    readValue.ReadAwardTable();
                }
                else if (tableName == "Comment")
                {
                    readValue.ReadCommentTable();
                }
                else if (tableName == "Category")
                {
                    readValue.ReadCategoryTable();
                }
                else if (tableName == "Like")
                {
                    readValue.ReadLikeTable();
                }
                else
                {
                    Console.WriteLine("Was entered the wrong name of the table");
                }
            }
            else if (Action == "add")
            {
                AddValue addValue = new AddValue();
                if (tableName == "User")
                {
                    addValue.AddUserTable();
                }
                else if (tableName == "Award")
                {
                    addValue.AddAwardTable();
                }
                else if (tableName == "Comment")
                {
                    addValue.AddCommentTable();
                }
                else if (tableName == "Category")
                {
                    addValue.AddCategoryTable();
                }
                else if (tableName == "Like")
                {
                    addValue.AddLikeTable();
                }
                else
                {
                    Console.WriteLine("Was entered the wrong name of the table");
                }
            }
            else if (Action == "update")
            {
                Update updateValue = new Update();
                if (tableName == "User")
                {
                    updateValue.UpdateUserTable();
                }
                else if (tableName == "Award")
                {
                    updateValue.UpdateAwardTable();
                }
                else if (tableName == "Comment")
                {
                    updateValue.UpdateCommentTable();
                }
                else if (tableName == "Category")
                {
                    updateValue.UpdateCategoryTable();
                }
                else if (tableName == "Like")
                {
                    updateValue.UpdateLikeTable();
                }
                else
                {
                    Console.WriteLine("Was entered the wrong name of the table");
                }
                //}
                //else if (Action == "delete")
                //{
                //    DeleteValue deleteValue = new DeleteValue();
                //    if (tableName == "User")
                //    {
                //        deleteValue.DeleteUserTable();
                //    }
                //    else if (tableName == "Award")
                //    {
                //        deleteValue.DeleteAwardTable();
                //    }
                //    else if (tableName == "Comment")
                //    {
                //        deleteValue.DeleteCommentTable();
                //    }
                //    else if (tableName == "Category")
                //    {
                //        deleteValue.DeleteCategoryTable();
                //    }
                //    else if (tableName == "Like")
                //    {
                //        deleteValue.DeleteLikeTable();
                //    }
                //    else
                //    {
                //        Console.WriteLine("Was entered the wrong name of the table");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Was entered the wrong Action");
            }

        }
    }
}
