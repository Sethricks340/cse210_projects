public class Scripture
{
    private string _scripture;
    private string _reference;
    private List<Word> _words = new List<Word>();
    private List<Reference> _references= new List<Reference>();
    private List<string> _scriptures = new List<string>();

    public Scripture()
    {
        //2 Nephi 2:27
        _scriptures.Add("Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.");
        //D&C 82:10
        _scriptures.Add("I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.");
        //Moses 1:39
        _scriptures.Add("For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");
        //John 15:20
        _scriptures.Add("Remember the word that I said unto you, The servant is not greater than his lord. If they have persecuted me, they will also persecute you; if they have kept my saying, they will keep yours also.");
        //Proverbs 3:5-6
        _scriptures.Add("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways aacknowledge him, and he shall direct thy paths.");

        Reference reference1 = new Reference("2 Nephi", "2", "27");
        Reference reference2 = new Reference("D&C", "82", "10");
        Reference reference3 = new Reference("Moses", "1", "39");
        Reference reference4 = new Reference("John", "15", "20");
        Reference reference5 = new Reference("Proverbs", "3", "5", "6");

        _references.Add(reference1);
        _references.Add(reference2);
        _references.Add(reference3);
        _references.Add(reference4);
        _references.Add(reference5);

        var random = new Random();
        var randomNumber = random.Next(0,_scriptures.Count);
        string randomScripture = _scriptures[randomNumber];
        _scripture = randomScripture;
        _reference = _references[randomNumber].GetReference();
        
    }

    public Scripture(string scripture)
    {
        _scripture = scripture;
    }

    public void DisplayScripture()
    {
        Console.Write($"{_reference}");
        foreach (var word in _words)
        {
            word.Display();
        }
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public void ResetScripture()
    {
        string enter;
        // Waiting for the user to press the enter key
        enter = Console.ReadLine();

        if (enter.ToLower() == "quit")
        {
            Environment.Exit(0);
        }

        else
        {
            // This will clear the console
            Console.Clear();
        }
    }

    public void ParseScripture()
    {
        List<string> words = new List<string>();
        
        string[] scriptureWords = _scripture.Split(" ");

        foreach (var word in scriptureWords)
        {
            words.Add(word);
        }
        
        for (int i = 0; i < words.Count; i++)
        {   
            Word newWord = new Word();
            _words.Add(newWord);
            _words[i].SetWord(words[i]);
        }
    }

    public void HideThreeRandomWords()
    {    
        int shownCount = 0;
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].GetShown() == true)
            {
                shownCount += 1;
            } 
        }

        if (shownCount < 3)
        {
            for (int i = 0; i < _words.Count; i++)
            {
                _words[i].HideWord();
            }
        }

        else
        {
            int count = 0;
            while (count < 3)
            {
                var random = new Random();
                var randomNumber = random.Next(0, _words.Count);

                if (_words[randomNumber].GetShown() == true)
                {
                    _words[randomNumber].HideWord();
                    count += 1;
                }
            }
        }
    }

    public int CountShownWords()
    {
        int shownCount = 0;
        for (int i = 0; i < _words.Count; i++)
        {
            if (_words[i].GetShown() == true)
            {
                shownCount += 1;
            } 
        }
        return shownCount;
    }
}