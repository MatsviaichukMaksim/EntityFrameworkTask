using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Information information = new Information();
            //information.GetTableNameAndAction();
            //Action action = new Action();
            //action.LaunchAction(information.ActionUser, information.TableName);
           
                while (true)
                {
                    try
                    {
                        Information information = new Information();
                        information.GetTableNameAndAction();
                        Action action = new Action();
                        if (information.Answer == "1")
                        {
                            action.LaunchAction(information.ActionUser, information.TableName);
                        }
                        else if (information.Answer == "2")
                        {
                            action.Request(information.RequestName);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error:{ex.Message}");
                    }
                }      
        }
    }
}
