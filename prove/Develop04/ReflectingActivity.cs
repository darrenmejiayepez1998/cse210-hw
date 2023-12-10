using System;
using System.Runtime.ExceptionServices;

public class ReflectingActivity : Activity
{
    private List<string> promtps;
    private List<string> questions;
    private HashSet<int> displayedPromptIndices;
    private HashSet<int> displayedQuestionIndices;

    public ReflectingActivity(string name, string description)
        : base(name, description)
    {
        InitializePrompts();
        InitializeQuestions();
        displayedPromptIndices = new HashSet<int>();
        displayedQuestionIndices = new HashSet<int>();
    }  

    private void InitializePrompts()
    {
        promtps = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you fulfilled a commitment." 
        };
    }  

    private void InitializeQuestions()
    {
        questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?" 
        };
    }

    public override void PrepareToBegin()
    {
        base.PrepareToBegin();
        ReflectOnExpierence();
    }   

    private void ReflectOnExpierence()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");

        for (int secondsRemaining = DurationInSeconds; secondsRemaining >0; secondsRemaining--)
        {
            DisplayRandomPrompt();
            Pause();
            AskRandomQuestion();
            Pause();
        }
    } 

    private void DisplayRandomPrompt()
    {
        int randomIndex;
        do
        {
            randomIndex = new Random().Next(promtps.Count);
        } while (displayedPromptIndices.Contains(randomIndex));

        displayedPromptIndices.Add(randomIndex);

        string randomPrompt = promtps[randomIndex];
        Console.WriteLine(randomPrompt);
    }

    private void AskRandomQuestion()
    {
        int randomIndex;
        do
        {
            randomIndex = new Random().Next(questions.Count);
        } while (displayedQuestionIndices.Contains(randomIndex));

        displayedQuestionIndices.Add(randomIndex);

        string randomQuestion = questions[randomIndex];
        Console.WriteLine(randomQuestion);
    }
    
    public override void End()
    {
        base.End(); // Call the base class method to display the common closing message
    }
}