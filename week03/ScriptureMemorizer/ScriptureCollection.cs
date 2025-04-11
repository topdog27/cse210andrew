using System;
using System.Collections.Generic;
using System.IO;

class ScriptureCollection
{
    private List<MemorizationScripture> _scriptures = new List<MemorizationScripture>();

    public ScriptureCollection(string filePath)
    {
        LoadFromFile(filePath);
    }

    private void LoadFromFile(string filePath)
    {
        // Debugging: Print file path to help locate the issue
        Console.WriteLine($"Looking for file at: {Path.GetFullPath(filePath)}");

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: Scripture file not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 2)
            {
                _scriptures.Add(new MemorizationScripture(ParseReference(parts[0]), parts[1]));
            }
        }

        // Debugging: Print loaded scripture count
        Console.WriteLine($"Loaded {_scriptures.Count} scriptures.");
    }

    private VerseReference ParseReference(string referenceText)
    {
        string[] refParts = referenceText.Split(' ');
        string book = refParts[0]; 

        string[] verseParts = refParts[1].Split(':'); 
        int chapter = int.Parse(verseParts[0]);

        string[] verseRange = verseParts[1].Split('-'); 
        int verseStart = int.Parse(verseRange[0]);
