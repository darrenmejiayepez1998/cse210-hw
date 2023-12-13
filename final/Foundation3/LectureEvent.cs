using System;

public class LectureEvent : Event
{
    private string speakerName;
    private int capacity;

    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public string GetLectureDetails()
    {
        return $"Speaker: {speakerName}\nCapacity: {capacity} attendees";
    }
}