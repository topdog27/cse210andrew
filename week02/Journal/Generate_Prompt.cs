using System;
using System.Collections.Generic;

public class TerminalServices
{
    public int _userResponse;
    public string _question;
    public List<string> _menu = new List<string>() { "1: Write", "2: Display", "3: Load", "4: Save", "5: Quit" };
    public List<string> _prompts = new List<string>() { "Today for breakfast I had ?", "The coolest thing that I saw today was", "The best part of my day was ", "The hardest part of my day was ", "the weather today was " };
    public void displayMenu()
    {
        Console.WriteLine("Menu:");
        foreach (string item in _menu)
        {
            Console.WriteLine(item);
        }
    }
    public void prompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        _question = _prompts[index];
        Console.WriteLine(_question);
    }
}
