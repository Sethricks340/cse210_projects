public class Board
{
    string _centerLetter = "";
    List<string> _otherLetters = new List<string>();
    List<string> _possibleWords = new List<string>();
    //List<string> _possibleWords = new List<string>();


    public Board()
    {}

    public void AddCenterLetter(string CenterLetter)
    {
        _centerLetter = CenterLetter;
    }

    public void AddOtherLetters(String Letter0, String Letter1, String Letter2, String Letter3, String Letter4, String Letter5)
    {
        _otherLetters.Add(Letter0);
        _otherLetters.Add(Letter1);
        _otherLetters.Add(Letter2);
        _otherLetters.Add(Letter3);
        _otherLetters.Add(Letter4);
        _otherLetters.Add(Letter5);
    }

    public void SortPossibleWords()
    {
        string[] lines = System.IO.File.ReadAllLines("EnglishWords.txt");
        
        foreach (string word in lines)
        {
            char[] letters = word.ToCharArray();

            bool contains = true;
            foreach (char letter in letters)
            {
                if (_otherLetters.Contains(letter.ToString()) && contains)
                {}
                else if(_centerLetter == letter.ToString() && contains)
                {}
                else
                {contains = false;}   

            }
                if (contains)
                {_possibleWords.Add(word);}

        }
        CheckIfGreaterThan3();
        CheckIfCenterLetter();
    }

    public void CheckIfGreaterThan3()
    {
        List<string> wordsToRemove = new List<string>();

    foreach (string word in _possibleWords)
    {
        if (word.Length <= 3)
        {
            wordsToRemove.Add(word);
        }
    }

    foreach (string wordToRemove in wordsToRemove)
    {
        _possibleWords.Remove(wordToRemove);
    }
    }

    public void CheckIfCenterLetter()
    {
        List<string> wordsToRemove = new List<string>();

        foreach (string word in _possibleWords)
    {
        if (!word.Contains(_centerLetter))
        {
            wordsToRemove.Add(word);
        }
    }

    foreach (string wordToRemove in wordsToRemove)
    {
        _possibleWords.Remove(wordToRemove);
    } 
    }

    public void PrintPossibleWords()
    {
        foreach (string word in _possibleWords)
        {
            Console.WriteLine($"{word}");
        }
    }
}