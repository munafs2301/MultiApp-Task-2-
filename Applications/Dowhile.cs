using System;
using System.Collections.Generic;
using System.Text;

namespace MultiApp.Applications
{
    class Dowhile
    {
        public static void Guessing()
        {
            // Generates a random number
            Random random = new Random();

            int randomnum = random.Next(1, 10);
            bool correctguess;
            try
            {
                // checks if user guess is equal to the random number generated
                do
                {
                    Console.Write("Guess a number: ");
                    int userguess = Convert.ToInt32(Console.ReadLine());

                    correctguess = (randomnum == userguess) ? true : false;
                } while (!correctguess);

                Console.WriteLine($"You made a correct guess of {randomnum}");
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number");
                Guessing();
            }

         

        }
    }
}
