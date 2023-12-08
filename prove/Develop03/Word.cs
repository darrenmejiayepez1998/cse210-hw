using System;

public class Word 
{
    private string text;
    public string Text
    {
        get {return text;}
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Word text cannot be null or empty.");
            }
            text = value;
        }
    }
    public bool IsHidden{get; set;}

    public int Verse{get; set;} // This is for the verse property in scripture 3

    
}