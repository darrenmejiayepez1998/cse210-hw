using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public class Entry 
{   
    public string _date; 
    public string _promptText;
    public string _entryText;
    private PromptGenerator pGen = new();

    public void Write()
    {
        /*
        PUBLIC Write()
        *_date = DateTime.Now.ToShortDateString()
        _promptText = pGen.GetRandomPrmpt()
        PUT _promptText             PUT: display to the console (Console.WriteLine())
        _entryText = GET            GET: get info from the user (Console.ReadLine())
        */
       
        _date = DateTime.Now.ToShortDateString();
        _promptText = pGen.GetRandomPrompt();
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
       
    }
    
    public void Display()
    {
        /*
        PUT _date
        PUT _promptText
        PUT _entryText
        */
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }
}