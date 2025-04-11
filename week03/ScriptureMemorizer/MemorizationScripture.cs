using System;
using System.Collections.Generic;

class MemorizationScripture
{
    private VerseReference _reference;
    private List<ScriptureWord> _words;
    private Random _random = new Random();

    public MemorizationScripture(VerseReference reference, string text)
    {
        _reference = reference;
        _words = new List<ScriptureWord>();

        foreach (string word in text.Split(' '))
        {
            _words.Add(new ScriptureWord(word));
        }
    }

    public void HideWords(int count)
    {
        List<ScriptureWord> visibleWords = _words.FindAll(w => !w.ToString().Contains("_"));

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(w => w.ToString().Contains("_"));
    }

    public override string ToString()
    {
        return $"{_reference}\n" + string.Join(" ", _words);
    }
}
