public class Scripture
{
    private string _scripture;
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string scripture)
    {
        _scripture = scripture;
    }

    public Scripture()
    {
    }

    public List<string> ParseScripture()
    {
        List<string> words = new List<string>();
        
        string[] scriptureWords = _scripture.Split(" ");

        foreach (var word in scriptureWords)
        {
            words.Add(word);
        }

        return words;
    }

    public void HideRandomWord(List<string> words)
    {
        var random = new Random();

        for (int i = 0; i < 2; i++)
        {
            var randomNumber = random.Next(0,words.Count);

        }



    }
}