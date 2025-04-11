class VerseReference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public VerseReference(string book, int chapter, int verseStart, int verseEnd = -1)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public override string ToString()
    {
        return _verseEnd == -1 ? $"{_book} {_chapter}:{_verseStart}" : $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}
