using System;

class Program
{
    static void Main(string[] args)
    {
        // create addresses
        Address eventAddress = new Address("123 Main St", "Seattle", "WA", "USA");

        // Events
        LectureEvent lectureEvent = new LectureEvent("How to become the 2.0 version of yourself", "Motivational talk about how to be better now!", DateTime.Now, TimeSpan.FromHours(2), eventAddress, "Bedros Kulian", 50000);
        ReceptionEvent receptionEvent = new ReceptionEvent("Tommy and Kenedy Reception", "Come spend time with the newly weds!", DateTime.Now, TimeSpan.FromHours(3), eventAddress, "rsvp@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Career fair", "Enjoy networking and learning about new opourtunities!", DateTime.Now, TimeSpan.FromHours(4), eventAddress, "Sunny skies");


        // Display Events
        Console.WriteLine(lectureEvent.GetMessage());
        Console.WriteLine(lectureEvent.GetLectureDetails() + "\n");

        Console.WriteLine(receptionEvent.GetMessage());
        Console.WriteLine(receptionEvent.GetRsvpDetails() + "\n");

        Console.WriteLine(outdoorGathering.GetMessage());
        Console.WriteLine(outdoorGathering.GetWeatherStatement() + "\n");
    }
}