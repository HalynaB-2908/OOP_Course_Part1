using System;

namespace SecondsToTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            int hours = seconds / 3600;
            int restSeconds = seconds % 3600; 

            int minutes = restSeconds / 60; 
            int remainingSeconds2 = restSeconds % 60; 

            Console.WriteLine(seconds + " seconds - is " + hours + " hour " + minutes + " minutes " + remainingSeconds2 + " seconds");
        }
    }
}

