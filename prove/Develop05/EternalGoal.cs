using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class EternalGoal : Goal
{
    public EternalGoal(string name) : base(name)
    {

    }

    // Eternal goals are never complete
}