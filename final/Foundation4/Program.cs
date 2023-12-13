using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity(DateTime.Now, 30, 3.0);
        CyclingActivity cyclingActivity = new CyclingActivity(DateTime.Now, 45, 15.0, 20.0);
        SwimmingActivity swimmingActivity = new SwimmingActivity(DateTime.Now, 60, 20);

        // listing each activity
        List<Activity> activities = new List<Activity>
        {
            runningActivity,
            cyclingActivity,
            swimmingActivity
        };

        // the display for each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}