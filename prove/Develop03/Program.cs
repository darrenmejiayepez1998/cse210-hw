using System;

class Program
{
    static void Main(string[] args)
    {
        // This creates each scripture
        List<Word> words1 = new List<Word>
        {
            new Word { Text = "In", IsHidden = false },
            new Word { Text = "the", IsHidden = false },
            new Word { Text = "beginning", IsHidden = false },
            new Word { Text = "God", IsHidden = false },
            new Word { Text = "created", IsHidden = false },
            new Word { Text = "the", IsHidden = false },
            new Word { Text = "heavens", IsHidden = false },
            new Word { Text = "and", IsHidden = false },
            new Word { Text = "the", IsHidden = false },
            new Word { Text = "earth", IsHidden = false } 
        };

        Scripture scripture1 = new Scripture(words1, "Genesis 1:1");

        List<Word> words2 = new List<Word>
        {
            new Word { Text = "For", IsHidden = false },
            new Word { Text = "behold,", IsHidden = false },
            new Word { Text = "this", IsHidden = false },
            new Word { Text = "is", IsHidden = false },
            new Word { Text = "my", IsHidden = false },
            new Word { Text = "work", IsHidden = false },
            new Word { Text = "and", IsHidden = false },
            new Word { Text = "my", IsHidden = false },
            new Word { Text = "glory", IsHidden = false },
            new Word { Text = "to", IsHidden = false },
            new Word { Text = "bring", IsHidden = false },
            new Word { Text = "to", IsHidden = false },
            new Word { Text = "pass", IsHidden = false },
            new Word { Text = "the", IsHidden = false },
            new Word { Text = "immortality", IsHidden = false },
            new Word { Text = "and", IsHidden = false },
            new Word { Text = "eternal", IsHidden = false },
            new Word { Text = "life", IsHidden = false },
            new Word { Text = "of", IsHidden = false },
            new Word { Text = "man", IsHidden = false },
        };

        Scripture scripture2 =new Scripture(words2,"Moses1:39");

        List<Word> words3 = new List<Word>
        {
          new Word { Text = "Come", IsHidden = false , Verse = 28},
          new Word { Text = "unto", IsHidden = false , Verse = 28},
          new Word { Text = "me,", IsHidden = false , Verse = 28},
          new Word { Text = "all", IsHidden = false , Verse = 28},
          new Word { Text = "ye", IsHidden = false , Verse = 28},
          new Word { Text = "that", IsHidden = false , Verse = 28},
          new Word { Text = "labour", IsHidden = false , Verse = 28},
          new Word { Text = "and", IsHidden = false , Verse = 28},
          new Word { Text = "are", IsHidden = false , Verse = 28},
          new Word { Text = "heavy laden,", IsHidden = false , Verse = 28},
          new Word { Text = "and", IsHidden = false , Verse = 28},
          new Word { Text = "I", IsHidden = false , Verse = 28},
          new Word { Text = "will", IsHidden = false , Verse = 28},
          new Word { Text = "give", IsHidden = false , Verse = 28},
          new Word { Text = "you", IsHidden = false , Verse = 28},
          new Word { Text = "rest.", IsHidden = false , Verse = 28},
          new Word { Text = "Take", IsHidden = false , Verse = 29},
          new Word { Text = "my", IsHidden = false , Verse = 29}, 
          new Word { Text = "yoke", IsHidden = false , Verse = 29},
          new Word { Text = "upon", IsHidden = false , Verse = 29},
          new Word { Text = "you,", IsHidden = false , Verse = 29},
          new Word { Text = "and", IsHidden = false , Verse = 29},
          new Word { Text = "learn", IsHidden = false , Verse = 29},
          new Word { Text = "of", IsHidden = false , Verse = 29},
          new Word { Text = "me;", IsHidden = false , Verse = 29},
          new Word { Text = "for", IsHidden = false , Verse = 29},
          new Word { Text = "I", IsHidden = false , Verse = 29},
          new Word { Text = "am", IsHidden = false , Verse = 29},
          new Word { Text = "meek", IsHidden = false , Verse = 29},
          new Word { Text = "and", IsHidden = false , Verse = 29},
          new Word { Text = "lowly", IsHidden = false , Verse = 29},
          new Word { Text = "in", IsHidden = false , Verse = 29},
          new Word { Text = "heart", IsHidden = false , Verse = 29},
          new Word { Text = "and", IsHidden = false , Verse = 29},
          new Word { Text = "ye", IsHidden = false , Verse = 29},
          new Word { Text = "shall", IsHidden = false , Verse = 29},
          new Word { Text = "find", IsHidden = false , Verse = 29},
          new Word { Text = "rest", IsHidden = false , Verse = 29},
          new Word { Text = "unto", IsHidden = false , Verse = 29},
          new Word { Text = "your", IsHidden = false , Verse = 29},
          new Word { Text = "souls.", IsHidden = false , Verse = 29},
          new Word { Text = "For", IsHidden = false , Verse = 30},
          new Word { Text = "my", IsHidden = false , Verse = 30},
          new Word { Text = "yoke", IsHidden = false , Verse = 30},
          new Word { Text = "is", IsHidden = false , Verse = 30},
          new Word { Text = "easy,", IsHidden = false , Verse = 30},
          new Word { Text = "and", IsHidden = false , Verse = 30},
          new Word { Text = "my", IsHidden = false , Verse = 30},
          new Word { Text = "burden", IsHidden = false , Verse = 30},
          new Word { Text = "is", IsHidden = false , Verse = 30},
          new Word { Text = "light", IsHidden = false , Verse = 30}, 
        };
        Scripture scripture3 = new Scripture(words3, "Mathew 11:28-30");

        // This is the list of each scripture
        List<Scripture> scriptures = new List<Scripture>
        {
            scripture1,
            scripture2,
            scripture3
        };

        // Randomly selects scripture
        Random random = new Random();
        Scripture selectedScriptures = scriptures[random.Next(scriptures.Count)];

        // pass the selected scripture to the reference class
        Reference reference = new Reference(selectedScriptures);

        // Runs the program
        reference.Run();
    }
}