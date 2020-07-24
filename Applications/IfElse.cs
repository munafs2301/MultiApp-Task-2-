using System;
using System.Collections.Generic;
using System.Text;

namespace MultiApp.Applications
{
    class IfElse
    {
        public static void CheckAge()
        {
            try
            {
                // Gets user's name and subtracts it from the current year to get the age
                Console.Write("Please enter your date of birth: ");
                DateTime userdate = Convert.ToDateTime(Console.ReadLine());
                DateTime dateTime = DateTime.Now;
                int age = dateTime.Year - userdate.Year;

                // Checks for age range and displays to user
                if (age <= 23)
                {
                    Console.WriteLine($"You are {age} years old and you belong to Generation X");
                }
                else
                {
                    Console.WriteLine($"You are {age} years old and you belong to Millenial Generation");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter date in this format: 12/12/2020");
                CheckAge();
            }

        }
    }
}
