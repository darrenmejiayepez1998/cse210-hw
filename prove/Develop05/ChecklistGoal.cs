using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ChecklistGoal : Goal
{
    private int targetCount;
    private int completedCount;

    public ChecklistGoal(string name, int targetCount) : base(name)
    {
        this.targetCount = targetCount;
        this.completedCount = 0;
    }

    public override void RecordEvent()
    {
        base.RecordEvent();
        completedCount++;

        if (completedCount == targetCount)
        {
            Console.WriteLine($"{Name} goal completed: Bonus points awarded.");
            Points += 500;
        }

    }
        protected override int CalculatePoints()
        {
            return 50;
        }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine($"Completed {completedCount}/{targetCount} times");
    }

}