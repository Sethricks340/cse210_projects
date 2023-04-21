using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        float number = PromptUserNumber();
        float squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program! ");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static float PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        float number = float.Parse(Console.ReadLine());
        return number;
    }

    static float SquareNumber(float number)
    {
        float squareNumber = number * number;
        return squareNumber;
    }

    static void DisplayResult(string name, float squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is: {squareNumber}");
    }

}