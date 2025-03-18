using System.IO;
using System.Collections.Generic;

public class File
{
    public string _fileName;

    public void WriteFile(List<Entry> journal)
    {
        Console.WriteLine("What is the filename?");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in journal)
            {
                outputFile.WriteLine($"{entry._date} || {entry._question} || {entry._userResponse}");
            }
        }
    }

    public List<Entry> ReadFile()
    {
        List<Entry> journal = new List<Entry>();

        Console.WriteLine("What is the filename?");
        _fileName = Console.ReadLine(); 

        string[] entries = System.IO.File.ReadAllLines(_fileName);

        foreach (string entry in entries)
        {
            string[] lines = entry.Split(" || "); 

        
            Entry newEntry = new Entry
            {
                _date = lines[0],
                _question = lines[1],
                _userResponse = lines[2]
            };

            journal.Add(newEntry);
        }
        return journal; 
    }
}