using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return lengthInMinutes / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}