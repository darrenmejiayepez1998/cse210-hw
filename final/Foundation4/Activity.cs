using System;
public class Activity
{
    private DateTime date;
    protected int lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // default implementation, it will be overridden by other classes
    }

    public virtual double GetSpeed()
    {
        return 0; // Same as getdistance function it will get overridden
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"Date: {date.ToShortDateString()}, Length: {lengthInMinutes} minutes";
    }
}