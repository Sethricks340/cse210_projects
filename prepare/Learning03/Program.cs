using System;

class Program
{
    static void Main(string[] args)
    {
        fraction fraction1 = new fraction();
        fraction fraction2 = new fraction(6);
        fraction fraction3 = new fraction(6,7);

        Console.WriteLine($"{fraction1.GetBottom()}");
        Console.WriteLine($"{fraction1.GetTop()}");

        fraction1.SetTop(6);
        fraction1.SetBottom(7);
        Console.WriteLine($"{fraction1.GetTop()}");
        Console.WriteLine($"{fraction1.GetBottom()}");
        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine($"{fraction1.GetDecimalValue()}");
    }
}