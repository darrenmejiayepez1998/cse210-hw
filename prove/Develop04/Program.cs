using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        bool quitProgram = false;

        while (!quitProgram)
        {
            DisplayMenu();

            String userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    StartActivity(new BreathingActivity("Breathing Activity", "Relax by focusing on your breathing."));
                    break;
                case "2":
                    StartActivity(new ReflectingActivity("Reflecting Activity", "Reflect on past expierences"));
                    break;
                case "3":
                    StartActivity(new ListingActivity("Listing Activity", "List things to appreciate"));
                    break;
                case "4":
                    Console.WriteLine("Exciting the program, thank you for using mindfulness!");
                    quitProgram = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                    break;                
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
    }

    static void StartActivity(Activity activity)
    {
        Console.Clear(); // Clears the console before starting a new activity
        activity.PrepareToBegin();
    }
}