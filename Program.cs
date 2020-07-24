using System;
using System.Collections.Generic;
using System.Text;

namespace MultiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome remarks
            Console.WriteLine("Hello user, welcome to MultiApp!!");

            // User selects an application from this function
            SelectOption.Options();

            // Exit remarks
            Console.WriteLine("Good bye from MultiApp.");

           
        }
    }
}
