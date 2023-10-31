using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Loss mitigation agent";
        job1._company = "Select Portfolio Services";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Sales Rep";
        job2._company = "Moxie Pest Control";
        job2._startYear = 2021;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Darren Mejia";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}