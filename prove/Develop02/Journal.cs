using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {

        _entries.Add(entry);
    }

    public void DisplayEntries() //displaying all journal entries
    {
        Console.WriteLine("Journal Entries~~ ");
        if (_entries.Count == 0)
            Console.WriteLine("No Entries Found.");
        else
        {
            foreach (Entry entry in _entries)
            {
                Console.WriteLine($"Date: {entry._date}");
                Console.WriteLine($"Prompt: {entry._prompt}");
                Console.WriteLine($"Response: {entry._response}");
                Console.WriteLine();
            }

        }
    }

    public void SaveToFile(string filename) //saving entries to file
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
        Console.WriteLine($"Saved to '{filename}'");
    }

    

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry entry = new Entry(prompt, response);
                    entry._date = date;
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"{filename}");
        }
        else
        {
            Console.WriteLine($"File '{filename}' not found.");
        }
    }

}