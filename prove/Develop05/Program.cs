using System;
using System.Collections;
using System.IO;
using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        // test goals
        //goalManager.AddGoal(new SimpleGoal("Send a gratitude text"));
        //goalManager.AddGoal(new EternalGoal("Read my scriptures"));
        //goalManager.AddGoal(new ChecklistGoal("Attend the temple", 10));
    

    // Menu Layout
    while(true)
    {
        Console.WriteLine("\nGoal Tracker Menu:");
        Console.WriteLine("1. Display Goals");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Add personal Goal");
        Console.WriteLine("4. Show total points");
        Console.WriteLine("5. Save Goals");
        Console.WriteLine("6. Load Goals");
        Console.WriteLine("7. Exit");

        string choice = Console.ReadLine();

        switch (choice)
        {
            
            case "1":
                goalManager.DisplayGoals();
                break;
            
            case "2":
                Console.Write("Enter the index of the goal to record the event: ");
                if (int.TryParse(Console.ReadLine(), out int goalIndex))
                {
                   
                }
                break;

            case "3":
                Console.WriteLine("Select the type of goal:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                string goalTypeChoice = Console.ReadLine();

                Console.Write("Enter the name of your goal: ");
                string customGoalName = Console.ReadLine();

                switch (goalTypeChoice)
                {
                    case "1":
                        goalManager.AddGoal(new SimpleGoal(customGoalName));
                        Console.WriteLine($"Simple goal '{customGoalName}' added.");
                        break;

                    case "2":
                        goalManager.AddGoal(new EternalGoal(customGoalName));
                        Console.WriteLine($"Eternal goal '{customGoalName}' added");
                        break;    

                    case "3":
                        Console.Write("Enter the amount of times you want to complete this activity: ");
                        if (int.TryParse(Console.ReadLine(), out int targetCount))
                        {
                            goalManager.AddGoal(new ChecklistGoal(customGoalName, targetCount));
                            Console.WriteLine($"Checklist goal '{customGoalName}' added");
                        }
                        else
                        {
                            Console.WriteLine("Invalid target count. Please enter a valid number.");
                        }
                        break;    
                }

                break;

            case "4":
                Console.WriteLine($"Total Points: ");
                break;

            case "5":
                goalManager.SaveGoals("goals.dat");
                Console.WriteLine("Goals saved successfully");
                break;

            case "6":
                goalManager.LoadGoals("Goals.dat");
                Console.WriteLine("Goals loaded succesfully.");
                break;

            case "7":
                Console.WriteLine("Exiting program. Thank you for using goal tracker!");
                return;

            default:
                Console.WriteLine("Invalid prompt please enter an option.");
                break;    
        }
    }
    }
}