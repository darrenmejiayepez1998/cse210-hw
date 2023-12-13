using System;

public class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return lengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}