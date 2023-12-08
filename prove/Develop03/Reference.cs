using System;
using System.ComponentModel;

public class Reference
{
    private Random random = new Random();
    private Scripture scripture;

    public Reference(Scripture scripture)
    {
        this.scripture = scripture;
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the scripture Memorizer!");

        DisplayScripture();

        while (true)
        {
            Console.WriteLine("\nPress 'Enter' to hide a random word of the scripture or type 'quit' to exit");

            string command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "":
                    HideRandomWord();
                    break;

                case "quit":
                    Console.WriteLine("Exiting the program. Thank you for using me!");
                    return;

                default:
                    Console.WriteLine("Invalid command. Please press 'Enter' or type 'quit'.");
                    break;
            }
        }
    }

    private void HideRandomWord()
    {
        int randomIndex= random.Next(scripture.WordCount);
        scripture.HideWord(randomIndex);

        // this displays the scripture with hidden words
        scripture.DisplayScripturewithReference();

        Console.WriteLine($"A word has been hidden at index {randomIndex}.");
    }

    private void DisplayScripture()
    {
        scripture.DisplayScripturewithReference();
    }
}