using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Create however many videos you want
        Video video1 = new Video("Jazzy Jingles ~ Smooth and Jazzy Nintendo Music","CrazyCloud",7200);
        Video video2 = new Video("We did it. Seriously.", "Caddicurus", 210);
        Video video3 = new Video("The Punisher (2004) - What Happened?", "Matt McMuscles", 1095);

        // Add comments to videos
        video1.AddComment("Darren", "This is good music to listen to while coding c#!");
        video1.AddComment("Random User", "Never heard these Jazzy covers!");

        video2.AddComment("Fan of Caddi", "I can not believe they did that!");
        video2.AddComment("Hypatia", "I dont understand the point of this.");

        video3.AddComment("PunisherFan1998", "I like the punisher and this is informative thanks for video!");
        video3.AddComment("Darren","I forgot Kevin Nash is in this movie!");

        // Display video details and comments
        DisplayVideoDetails(video1);
        DisplayVideoDetails(video2);
        DisplayVideoDetails(video3);
    }

    static void DisplayVideoDetails(Video video)
    {
        Console.WriteLine($"Video: {video.Title} by {video.Author}");
        Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
        Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

        foreach (var comment in video.Comments)
        {
            Console.WriteLine($"Comment by: {comment.CommenterName}: {comment.CommentText}");

            Console.WriteLine();
        }
    }
}