using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        Console.WriteLine("Type a list of numbers, enter 0 when finished. ");
        while (number != 0)
        {
            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }


        Console.WriteLine("Here is your list of numbers: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write($"{numbers[i]}, ");

        }
            int sum = numbers.Sum();
            Console.WriteLine($"\nThe sum of your numbers is: {sum}");
            double avg = numbers.Average();
            Console.WriteLine($"The average of your numbers is: {avg}");

        long largest = -1;
        for (int i = 0; i < numbers.Count -1; i++)
        {
            if(numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        long smallest = 9999;
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if(numbers[i] < smallest && numbers[i] > 0)
            {
                smallest = numbers[i];
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallest}");
        numbers.Sort();
        Console.WriteLine($"Here is the sorted list of numbers");
        foreach(var value in numbers)
        {
            Console.WriteLine($"{value}");
        }
    }
}