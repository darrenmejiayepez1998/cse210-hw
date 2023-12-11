using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class GoalManager
{
    private List<Goal> goals;
    private int totalPoints;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalPoints = 0;
    }

    public int TotalPoints => totalPoints;

    // Save goals to a file
    public void SaveGoals(string fileName)
    {
        try
        {
            string Json = JsonSerializer.Serialize(goals);
            File.WriteAllText(fileName, Json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    // Load goals from a file
    public void LoadGoals(string fileName)
    {
        try
        {
           string Json = File.ReadAllText(fileName);
           goals = JsonSerializer.Deserialize<List<Goal>>(Json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void EnterCustomGoal()
    {
        Console.Write("Enter the name of your goal: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter a brief description of the goal: ");
        string goalDescription = Console.ReadLine();

        Console.Write("Choose a type of goal (1. Simple, 2. Eternal 3. Checklist)");
        if (int.TryParse(Console.ReadLine(), out int goalType))
        {
            Goal newGoal;

            switch (goalType)
            {
                case 1:
                    newGoal = new SimpleGoal(goalName);
                    newGoal = new SimpleGoal(goalDescription);
                    break;
                case 2:
                    newGoal = new EternalGoal(goalName);
                    newGoal = new EternalGoal(goalDescription);
                    break;
                case 3:
                    Console.Write("Enter the target count for the checklist goal");
                    if (int.TryParse(Console.ReadLine(), out int targetCount))
                    {
                        newGoal = new ChecklistGoal(goalName, targetCount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type. Goal not added.");
                        return;
                    }
                    break;    
            }
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nCurrent Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"[{i + 1}] {goals[i].Name}");

            if (goals[i].IsCompleted)
            {
                Console.Write(" [X]");
            }
            else 
            {
                Console.Write(" [ ]");
            }
        }
    }

    
}