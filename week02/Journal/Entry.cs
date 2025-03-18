using System;

public class Entry
{
    public string _userResponse;
    public string _date;
    public string _question;

    public Entry ()
    {
        DateTime now = DateTime.Now;
        _date = now.ToShortDateString();
    }

    public void SetEntry(string userResponse, string question, string date = null)
    {
        _userResponse = userResponse;
        _question = question;
        _date = date ?? _date;
    }
    
    public void DisplayEntry()
    {   
        Console.WriteLine($"Date: {_date} - Prompt: {_question}\n{_userResponse}");
        Console.WriteLine();
    }
}