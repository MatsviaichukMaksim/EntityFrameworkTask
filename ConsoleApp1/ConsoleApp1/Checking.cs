using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Checking
    {
        public static string CheckEnteredString(string stringEnteredUser)
        {
            if(String.IsNullOrEmpty(stringEnteredUser))
            {
                //return false;
                Console.WriteLine("You haven't written a data");
                //throw new NullReferenceException();
            }
            return stringEnteredUser;
            //return true;
        }
    }
}
