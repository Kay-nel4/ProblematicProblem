using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;

namespace ProblematicProblem
{

    public class Program
    {
        static void Main(string[] args)


        {
            Random rng = new Random();
            List<string> activities = new List<string>()
            {
                "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting"
            };

            {
                Console.Write(
                    "Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
                var answer = Console.ReadLine().Trim().ToLower();
                while (answer != "yes" && answer != "no")
                {
                    Console.WriteLine("A Yes or No answer Please.");
                    answer = Console.ReadLine().Trim().ToLower();
                }

                if (answer == "no")
                {
                    Console.WriteLine("Goodbye!");
                }

                if (answer == "yes")
                {
                    Console.WriteLine();
                    Console.Write("We are going to need your information first! What is your name? ");
                    var userName = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("What is your age? ");
                    int age;
                    while (!int.TryParse(Console.ReadLine(), out age))
                    {
                        Console.WriteLine("Please enter a valid age.");
                    }

                    Console.WriteLine();
                    Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                    var seeList = Console.ReadLine().Trim().ToLower();
                    while (seeList != "no" && seeList != "no thanks" && seeList != "yes" && seeList != "sure")
                    {
                        Console.Write("Please choose Sure or No Thanks: ");
                        seeList = Console.ReadLine().Trim().ToLower();
                    }

                    if (seeList == "no thanks" || seeList == "no")
                    {
                        Console.WriteLine("Ok Goodbye!");
                        return;
                    }

                    if (seeList == "sure" || seeList == "yes")

                        foreach (string activity in activities)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{activity}, ");
                            Thread.Sleep(250);

                        }

                    Console.ResetColor();

                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    var addToList = Console.ReadLine().Trim().ToLower();

                    while (addToList != "yes" && addToList != "no")
                    {
                        Console.Write("Please enter a Yes or No: ");
                        addToList = Console.ReadLine().Trim().ToLower();
                    }
                    if (addToList == "yes")
                    {
                        Console.WriteLine();
                        while (addToList.Trim().ToLower() == "yes")
                        {
                            Console.Write("What would you like to add? ");
                            string userAddition = Console.ReadLine();
                            activities.Add(userAddition);
                            foreach (string activity in activities)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write($"{activity}, ");
                                Thread.Sleep(250);
                            }

                            Console.ResetColor();

                            Console.WriteLine();
                            Console.Write("Would you like to add more? yes/no: ");

                            while (addToList != "yes" && addToList != "no")
                            {
                                Console.Write("Please enter a Yes or No: ");
                                addToList = Console.ReadLine().Trim().ToLower();
                            }

                            if (Console.ReadLine().Trim().ToLower() == "yes")
                            {
                                addToList = (Console.ReadLine());
                                activities.Add(addToList);
                            }
                            //need to figure out a way to say no and still continue on to the next step...
                            {        
                                Console.Write("Connecting to the database");
                                for (int i = 0; i < 1; i++)
                                {
                                    Console.Write(". ");
                                    Thread.Sleep(500);
                                }

                                Console.WriteLine();
                                Console.Write("Choosing your random activity");
                                for (int i = 0; i < 1; i++)
                                {
                                    Console.Write(". ");
                                    Thread.Sleep(500);

                                    Console.WriteLine();
                                    var randomNumber = rng.Next(activities.Count);
                                    var randomActivity = activities[randomNumber];

                                    if ((age < 21) && (randomActivity) == "Wine Tasting")
                                    {
                                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                                        Console.WriteLine("Pick something else!");
                                        activities.Remove(randomActivity);
                                        Random rngTwo = new Random();
                                        var activityTwo = rngTwo.Next(activities.Count);
                                        string randomActivityTwo = activities[activityTwo];

                                        Console.Write($"Ah got it! {userName}, your random activity is: {randomActivityTwo}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                                    }

                                    Console.WriteLine(
                                        $"Ah got it! {userName}, your random activity is {randomActivity}");
                                    Console.WriteLine(
                                        "Thanks for using the Random Activity Generator... Enjoy your Activity!");
                                }

                                break;

                            }


                        }
                    }
                }
            }
        }
    }
}



//Need to come back to this one its great practice for different types of loops.
    
                    
                
    
