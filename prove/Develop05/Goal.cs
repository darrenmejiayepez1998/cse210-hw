using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Goal
{
   public string Name {get; }
   public bool IsCompleted {get; protected set; }
   public int Points {get; protected set;}
   


    public Goal(string name)
    {
        Name = name;
        IsCompleted = false;
        Points = 0;
    }

    public virtual void RecordEvent()
    {
        IsCompleted = true;
        Points += CalculatePoints();
    }

    protected virtual int CalculatePoints()
    {
        // Default point calculation applicable for Simple and Eternal goals 
        return 0;
    }
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"{Name} - Points: {Points}");
    }
}