public class PromptGenerator
{
    public List<string> _prompts = new()
    {
        "What was the best part of the day today?",
        "What is something I am gratefull for today?",
        "How did I see the hand of the Lord today?",
        "Did I learn anything interesting today?",
        "Is there anything I could imporve on for tomorrow?",
    };
    private Random rnd = new();

    public string GetRandomPrompt()
    {

        int index = rnd.Next(_prompts.Count);

        return _prompts[index];
        /*
        NOTE: generates random number (int)
        */
    }
}