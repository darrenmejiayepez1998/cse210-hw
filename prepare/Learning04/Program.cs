using System;

class Program
{
    static void Main(string[] args)
    {
        // base object
        Assignment a1 = new Assignment("Darren Mejia", "Divisions");
        Console.WriteLine(a1.GetSummary());

        // sub class assigments
        MathAssignment a2 = new MathAssignment("Darren Mejia", "Pre algerbra", "7.5", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Darren Mejia", "Videogame Writing", "How to write a compeling videogame character");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    } 
}