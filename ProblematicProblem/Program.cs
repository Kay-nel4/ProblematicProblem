using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Threading;

namespace ProblematicProblem
{

    public class Program
    {
        static string userInput;
        static Random random = new Random();
        static bool cont = true;
        static List<string> activities = new List<string>()
        {
            "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting"
        };
       
        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            userInput = Console.ReadLine().Trim().ToLower();
            while (userInput != "yes" && userInput != "no")
            {
                Console.WriteLine("A Yes or No answer Please.");
                userInput = Console.ReadLine().Trim().ToLower();
            }

            if (userInput != "yes")
            {
                Console.WriteLine("Goodbye!");
                return;
            }

            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
               
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.TryParse(Console.ReadLine(), out userAge) ? userAge : 0;
            while (userAge == 0)
            {
                Console.WriteLine("Please enter a valid age.");
            }
            Console.WriteLine("Would you like to see the current list of activities? Sure/No thanks: ");
            Console.WriteLine();
            
            userInput = Console.ReadLine().Trim().ToLower();
            
            while (userInput != "no" && userInput != "no thanks" && userInput != "yes" && userInput != "sure")
            {
                Console.Write("Please choose Sure or No Thanks: ");
                userInput = Console.ReadLine().Trim().ToLower();
            }

               
            if (userInput == "sure")
            {
                foreach (string activity in activities)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{activity}, ");
                    Thread.Sleep(250);
                }

                Console.WriteLine("Would you like to add anything to the list of activities? Yes/No: ");
                string addToList = Console.ReadLine();
                
                Console.WriteLine();

                while (addToList.ToLower() != "no")
                {
                    Console.Write("what would you like to add? ");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    foreach (string activity in activities)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{activity}, ");
                        Thread.Sleep(250);
                    }

                    Console.Write("Would you like to add anything else? Yes/No : ");
                    addToList = Console.ReadLine();
                }

                   //if (seeList == "no thanks" || seeList == "no")
                   //{
                   //Console.WriteLine("Ok Goodbye!");
                   //return;
                   //}

                Console.ResetColor();

                Console.WriteLine();
            }
               //Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    //var addToList = Console.ReadLine().Trim().ToLower();
                        
                    
                   /* while (addToList != "yes" && addToList != "no")
                    {
                        Console.Write("Please enter a Yes or No: ");
                        addToList = Console.ReadLine().Trim().ToLower();
                    }*/
                    /*if (addToList == "yes")
                    {
                        Console.WriteLine();
                        while (addToList.Trim().ToLower() == "yes")
                        {
                            Console.Write("What would you like to add? ");
                           

                            Console.ResetColor();

                            Console.WriteLine();
                            Console.Write("Would you like to add more? yes/no: ");

                            /*while (addToList != "yes" && addToList != "no")
                            {
                                Console.Write("Please enter a Yes or No: ");
                                addToList = Console.ReadLine().Trim().ToLower();
                            }*/

                            /*if (Console.ReadLine().Trim().ToLower() == "yes")
                            {
                                addToList = (Console.ReadLine());
                                activities.Add(addToList);
                            }
                            //need to figure out a way to say no and still continue on to the next step...
                            {*/
            do
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                Console.Write("Choosing your random activity");
                
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine(); 
                int randomNumber = random.Next(activities.Count);
                string randomActivity = activities[randomNumber];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                    randomNumber = random.Next(activities.Count);
                    randomActivity = activities[randomNumber];
                }

                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                                
                userInput = Console.ReadLine();
                if (userInput.ToLower() != "redo")
                {
                    cont = false;
                }

            } while (cont);
        }
    }
}



//Need to come back to this one its great practice for different types of loops.
    
                    
                
    
