public class Reference
{
    private string _book;
    private string _chapter;
    private string _firstVerse;
    private string _lastVerse = "";
    
    public Reference(string book, string chapter, string firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
    }
    public Reference(string book, string chapter, string firstVerse, string lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }
    
    public string GetReference()
    {
        string reference;
        if (_lastVerse == "")
        {
            reference = $"{_book} {_chapter}:{_firstVerse} ";
        }

        else
        {
            reference = $"{_book} {_chapter}:{_firstVerse}-{_lastVerse} ";
        }

        return reference;
    }
}