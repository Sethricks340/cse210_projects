using System;

class Program 
{
    static void Main(string[] args)
    {
        Sodavine sodavine = new Sodavine();

        string izzy_order = sodavine.GetRandomPrompt();
        Console.WriteLine($"\nWhat would you like from Sodavine, Izzy? <3 ");
        Console.WriteLine($"This is your randomly generated drink: {izzy_order}\n");

    }
}