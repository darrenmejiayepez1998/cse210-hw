using System;

public class Activity
{
    public string Name {get; set;}
    public string Description {get; set;}
    public int DurationInSeconds {get; set;}

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
        DurationInSeconds = GetUserInput("Enter the duration of the activity in seconds: ");
    }

    public virtual void PrepareToBegin()
    {
        Console.WriteLine($"Prepare to begin {Name}...");
        Pause();
    }

    protected virtual void Pause()
    {
        // The countdown timer ilusion
        for(int i = 3; i >= 1; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

   private int GetUserInput(string prompt)
   {
    Console.Write(prompt);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int result) && result > 0)
        {
            return result;
        } 
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");       
        }
    }
   } 

   public virtual void End()
   {
        Console.WriteLine("Thank you for using mindfulness!");
        // takes you back to main menu
   }
}