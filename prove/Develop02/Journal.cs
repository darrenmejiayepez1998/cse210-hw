using System.IO;
public class Journal

{
    private List<Entry> _entries = new();

    public void AddEntry()
    {
        Entry entry = new();
        entry.Write();
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        //  FOREACH entry in entries
        //      entry.Display()

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter output = new(file, true))
        {
            foreach(Entry entry in _entries)
            {
                output.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        _entries.Clear();
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        //  string[] lines = File.ReadAllLines(file)
        //  FOREACH line in lines
        //      string[] parts = line.Split("|")
        //      Entry entry = new()
        //      entry._date = parts[0]
        //         ...
        //      _entries.Add(entry)
        string[] lines = File.ReadAllLines(file);
        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }

        
    }
}