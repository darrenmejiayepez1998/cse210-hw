using System;

public class CyclingActivity : Activity
{
    private double distance;
    private double speed;

    public CyclingActivity(DateTime date, int lengthInMinutes, double distance, double speed)
        :base(date, lengthInMinutes)
    {
        this.distance = distance;
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}, Distance: {distance} miles, Speed: {speed} mph, Pace: {GetPace()} min per mile";
    }
}