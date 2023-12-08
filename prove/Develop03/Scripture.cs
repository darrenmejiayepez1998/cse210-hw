using System;

public class Scripture
{
    private List<Word> words;
   
   // the scriptureRefrence string and code saves the refrence for program class
   public Scripture(List<Word> words, string scriptureReference)
   {
    this.words = words;
    this.ScriptureReference = scriptureReference;
   }

   public string ScriptureReference {get; private set; }

   public void DisplayScripturewithReference()
   {
    Console.WriteLine($"Scripture Reference: {ScriptureReference}");
    Console.WriteLine($"Scripture Text:");
    foreach(var word in words)
    {
        if (word.IsHidden)
        {
            Console.Write("_ ");
        }
        else
        {
            Console.Write(word.Text + " ");
        }
    }
    Console.WriteLine();
   } 

   public void HideWord(int index)
   {
    if (index >= 0 && index < words.Count)
    {
        words[index].IsHidden = true; // This actually hides each word
    }
   }

   public int WordCount // This makes the property public
   {
       get {return words.Count;}
   }

    public void DisplayScripture()
    {
        foreach (var word in words)
        {
            if (word.IsHidden)
            {
                Console.Write("_"); // Place holder for hidden words
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }

         Console.WriteLine(); // Moves to the next line after displaying all words
    }
}