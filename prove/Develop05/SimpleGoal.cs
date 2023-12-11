using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name) : base(name)
    {
    }

    protected override int CalculatePoints()
    {
        return 1000;
    }
}


