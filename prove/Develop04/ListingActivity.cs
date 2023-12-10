using System;

public class ListingActivity : Activity
{
    private List<string> prompts;
    private HashSet<int> displayPromptIndices;

    public ListingActivity(string name, string description)
        : base(name, description)
    {
        InitializePrompts();
        displayPromptIndices = new HashSet<int>();
    }

    private void InitializePrompts()
    {
        prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "Who is someone that you are gratefull for?",
            "What is something new that you learned today?",
            "Who did you tell that you love them?" 
        };
    }

    public override void PrepareToBegin()
    {
        base.PrepareToBegin();
        ReflectOnPrompt();
    }

    private void ReflectOnPrompt()
    {
         Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

         for (int secondsRemaining = DurationInSeconds; secondsRemaining > 0; secondsRemaining--)
         {
            DisplayRandomPrompt();
            Pause();
            ListItems();
            Pause();
         } 
    }

    private void DisplayRandomPrompt()
    {
        int randomIndex;
        do
        {
            randomIndex = new Random().Next(prompts.Count);
        }while (displayPromptIndices.Contains(randomIndex));

        displayPromptIndices.Add(randomIndex);

        string randomPrompt = prompts[randomIndex];
        Console.WriteLine(randomPrompt);
    }

    private void ListItems()
    {
        Console.WriteLine($"You have {DurationInSeconds} seconds to list as many items as you can.");

        // This captures the user specified duration
        DateTime endTime = DateTime.Now.AddSeconds(DurationInSeconds);
        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("Type an answer: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        // This displays the amount of answers typed
        Console.WriteLine($"You typed {items.Count} answers.");
    }

    public override void End()
    {
        base.End(); // Call the base class method to display the common closing message
    }
}