using System;
using MultiApp.Applications;

namespace MultiApp
{
    static class SelectOption
    {
       public static void Options()
        {
            // Displays a list of application the user can use
            Console.WriteLine(@"
Choose an application to use ...
1. Video Converter (MP3)
2. Guess a number (Game)
3. Airtime Generator
4. Age Calculator");

            Console.Write("\n Enter a number to make a selection:");
            try
            {
                /// User input
                int userInput = Convert.ToInt32(Console.ReadLine());

                // Selects a function to implement based on user input
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("================");
                        Console.WriteLine("VIDEO CONVERTER");
                        Console.WriteLine("================");
                        ForEach.Video();
                        break;
                    case 2:
                        Console.WriteLine("==============");
                        Console.WriteLine("GUESS A NUMBER");
                        Console.WriteLine("==============");
                        Dowhile.Guessing();
                        break;

                    case 3:
                        Console.WriteLine("=================");
                        Console.WriteLine("AIRTIME GENERATOR");
                        Console.WriteLine("=================");
                        ForLoop.NumGenerator();
                        break;

                    case 4:
                        Console.WriteLine("==============");
                        Console.WriteLine("AGE CALCULATOR");
                        Console.WriteLine("==============");
                        IfElse.CheckAge();
                        break;
                }
            }

            catch (Exception)
            {

                Console.WriteLine("Wrong input!!! Please enter a number. \n");
                Options();
            }


            Console.Write("Do you want to do someting else (yes/no):");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                SelectOption.Options();
            }
            else if (answer == "no")
            {
                Console.WriteLine("Press Enter to exit....");

                // Waiting for enter
                Console.ReadLine();
            }
            else
            {
                
            }
        }




        }
    }

