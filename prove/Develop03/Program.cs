using System;

class Program
{
    static void Main(string[] args)
    {
        Word word = new Word("Capricious");
        word.display();
        //word.HideWord();
        word.SetWord("Capricious");
        word.HideWord();
        word.display();

        Scripture scripture = new Scripture("And it came to pass, that I wrote some code.");
        List<string>words = new List<string>();
        words = scripture.ParseScripture();

        foreach (string scriptureWord in words)
        {
            Console.WriteLine($"{scriptureWord}");
        }
    }
}