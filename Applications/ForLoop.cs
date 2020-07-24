using System;
using System.Collections.Generic;
using System.Text;

namespace MultiApp.Applications
{
    class ForLoop
    {
        public static void NumGenerator()
        {
            try
            {
                // Gets the number of times of the while loop will run
                Console.Write("How many recharge card: ");
                int repition = 0;
                int number_of_cards = Convert.ToInt32(Console.ReadLine());

                while (repition < number_of_cards)
                {
                    // Generates a 12 digit random numbers
                    for (int count = 0; count < 12; count++)
                    {

                        Random randomNum = new Random();

                        int num = randomNum.Next(1, 10);
                        Console.Write($"{num} ");

                    }
                    Console.WriteLine();
                    repition += 1;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Incorrect input. Enter numbers such as 1 2 3...");
                NumGenerator();
            }
            

        }
    }
}
