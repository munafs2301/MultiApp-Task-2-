using System;
using System.Collections.Generic;
using System.Text;

namespace MultiApp.Applications
{
    class ForEach
    {
        public static void Video()
        {
            
            List<string> videolist = new List<string>();


            try
            {
                // Gets the number of videos to be converted
                Console.Write("How many videos do you want to convert to mp3: ");
                int videonum = Convert.ToInt32(Console.ReadLine());

                // Requests for video name and adds it to the empty collection
                for (int i = 1; i <= videonum; i++)
                {
                    Console.Write($"Enter the title for video {i}: ");
                    videolist.Add(Console.ReadLine());
                }
                // A shallow part of video to mp3 conversion process: adds ".mp3" to the video names
                Console.WriteLine("\n Converting videos.... \n");
                Console.WriteLine("Here is a list of your converted videos:");
                foreach (var item in videolist)
                {
                    string newMP3 = item + ".mp3";
                    Console.WriteLine(newMP3);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Incorrect input. Enter numbers such as 1 2 3...");
                Video();
                
            }

         }
    }
}
