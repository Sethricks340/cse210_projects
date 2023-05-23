public class Word
{
    private string _word;
    private bool _shown = true;


    public Word(string word)
    {
        _word = word;
    }

    public Word()
    {
    }

    public bool GetShown()
    {
        return _shown;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public void Display()
    {
        Console.Write($"{_word} ");
    }

    public void HideWord()
    {
        string newWord = "";
        
        for (int i = 0; i < _word.Count(); i++)
        {
            newWord += "_";
        }
        
        _word = newWord;
        _shown = false;
    }
}