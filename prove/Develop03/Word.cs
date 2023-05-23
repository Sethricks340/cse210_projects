public class Word
{
    private string _word;
    private bool shown = true;


    public Word(string word)
    {
        _word = word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public void display()
    {
        Console.WriteLine($"{_word}");
    }

    public void HideWord()
    {
        string newWord = "";
        
        for (int i = 0; i < _word.Count(); i++)
        {
            newWord += "_";
        }
        _word = newWord;
    }
}