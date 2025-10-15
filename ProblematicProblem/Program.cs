using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;

namespace ProblematicProblem
{

    class Program
    {
        static void Main(string[] args)


        {
            Random rng = new Random();
            List<string> activities = new List<string>() {"Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
            
            {
                Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
                var answer = Console.ReadLine();
                if (answer.Trim().ToLower() == "yes")
                {
                    Console.WriteLine();
                    Console.Write("We are going to need your information first! What is your name? ");
                    var userName = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("What is your age? ");
                    var userAge = Console.ReadLine();
                    var age = int.Parse(userAge);
                    Console.WriteLine();
                    Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                    var seeList = Console.ReadLine();
                    if (seeList.Trim().ToLower() == "sure" || seeList.Trim().ToLower() == "yes")
                    {
                        foreach (string activity in activities)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write($"{activity}, ");
                            Thread.Sleep(250);
                             
                            
                        }
                        Console.ResetColor();
                        
                        Console.WriteLine();
                        Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                        var addToList = Console.ReadLine();
                        if (addToList.Trim().ToLower() == "yes")
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
                                    Console.Write($"{activity} ");
                                    Thread.Sleep(250);
                                }
                                Console.ResetColor();

                                Console.WriteLine();
                                Console.WriteLine("Would you like to add more? yes/no: ");
                            
                                if (Console.ReadLine().Trim().ToLower() == "yes")
                                {
                                    var addToListAgain = (Console.ReadLine());
                                    activities.Add(addToListAgain);
                                }
                                else
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
                                            Console.WriteLine(
                                                $"Oh no! Looks like you are too young to do {randomActivity}");
                                            Console.WriteLine("Pick something else!");
                                            activities.Remove(randomActivity);
                                            Random rngTwo = new Random();
                                            var activityTwo = rngTwo.Next(activities.Count);
                                            string randomActivityTwo = activities[activityTwo];

                                            Console.Write(
                                                $"Ah got it! {userName}, your random activity is: {randomActivityTwo}  ! Is this ok or do you want to grab another activity? Keep/Redo: ");
                                        }

                                        Console.WriteLine(
                                            $"Ah got it! {userName}, your random activity is {randomActivity}");
                                        Console.WriteLine("Thanks for using the Random Activity Generator... Enjoy your Activity!");
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
}

//Need to come back to this one its great practice different kinds of loops.
    
                    
                
    
