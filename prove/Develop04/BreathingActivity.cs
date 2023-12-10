using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description)
    {
    }

    public override void PrepareToBegin()
    {
        base.PrepareToBegin();
        PerformBreathingExercise();
    }    

    private void PerformBreathingExercise()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breathing.");

        for (int secondsRemaining = DurationInSeconds; secondsRemaining > 0; secondsRemaining--)
        {
            BreatheIn();
            Pause();
            BreatheOut();
            Pause();
        }
    }

    private void BreatheIn()
    {
        Console.WriteLine("Breathe in...");
    }

    private void BreatheOut()
    {
        Console.WriteLine("Breathe out...");
    }

    public override void End()
    {
        base.End(); // Call the base class method to display the common closing message
    }
}