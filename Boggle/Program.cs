class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Board board = new Board();
        // board.AddCenterLetter("p");
        // board.AddOtherLetters("a", "e", "h", "l", "t", "y");

        Console.WriteLine("What is the center letter?");
        string CenterLetter = Console.ReadLine();
        Console.WriteLine("Outer letter 1: ");
        string OuterLetter0 = Console.ReadLine();
        Console.WriteLine("Outer letter 2: ");
        string OuterLetter1 = Console.ReadLine();
        Console.WriteLine("Outer letter 3: ");
        string OuterLetter2 = Console.ReadLine();
        Console.WriteLine("Outer letter 4: ");
        string OuterLetter3 = Console.ReadLine();
        Console.WriteLine("Outer letter 5: ");
        string OuterLetter4 = Console.ReadLine();
        Console.WriteLine("Outer letter 6: ");
        string OuterLetter5 = Console.ReadLine();

        board.AddCenterLetter(CenterLetter);
        board.AddOtherLetters(OuterLetter0, OuterLetter1, OuterLetter2, OuterLetter3, OuterLetter4, OuterLetter5);

        Console.Clear();
        board.SortPossibleWords();
        board.PrintPossibleWords();





    }
}