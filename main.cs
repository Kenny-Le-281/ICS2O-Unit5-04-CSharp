// Created by: Kenny Le
// Created on: May 2022
//
// This program determines what type of movie you can see

using System;

class Program
{
    public static void Main(string[] args)
    {
        string date;
        int day;

        Console.WriteLine("What will the price of the museum admisson be?");
        Console.WriteLine("");

        void admission()
        {
            Console.WriteLine("Enter the day");
            Console.WriteLine("");
            Console.WriteLine("Sunday");
            Console.WriteLine("Monday");
            Console.WriteLine("Tuesday");
            Console.WriteLine("Wednesday");
            Console.WriteLine("Thursday");
            Console.WriteLine("Friday (T)");
            Console.WriteLine("Saturday");
            date = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Enter your age");
            age = Console.ReadLine();

            if (date == "Adult")
            {
                Console.WriteLine("You can see a R rated movie alone.");
            }
            else if (ageGroup == "Teen")
            {
                Console.WriteLine("You can see a PG-13 rated movie alone.");
            }
            else if (ageGroup == "Child")
            {
                Console.WriteLine("You can see a G or PG rated movie alone.");
            }
            else
            {
                Console.WriteLine("You are too young too watch a movie alone. Sorry!");
            }
        }

        movieTypes();
        Console.WriteLine("\nDone.");
    }
}