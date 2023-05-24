using System;

class Program
{
    static void Main(string[] args)
    {
        //To exceed requirements:
        //The scriptures and references can be set by hand, if not then a random scripture is generated.
        //Random words are chosen only from those that have not already been erased.

        // Reference reference = new Reference("2 Nephi", "2", "27");
        // Scripture scripture = new Scripture("Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.");
        Scripture scripture = new Scripture();
        Console.Clear();
        scripture.ParseScripture();
        scripture.DisplayScripture();
        Console.WriteLine($"\n\nPress enter to continue or type 'quit' to finish: ");
        
        while (scripture.CountShownWords() != 0)
        {
            scripture.ResetScripture();
            scripture.HideThreeRandomWords(); 
            // Console.Write($"{reference.GetReference()}");
            scripture.DisplayScripture();
            Console.WriteLine($"\n\nPress enter to continue or type 'quit' to finish: ");
        }
        Console.ReadLine();
    }
}