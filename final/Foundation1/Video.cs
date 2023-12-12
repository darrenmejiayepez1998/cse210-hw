using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class Video
{
    public string Title {get; private set;}
    public string Author {get; private set;}
    public int LengthInSeconds {get; private set;}
    public List<Comment> Comments {get; private set;}

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}