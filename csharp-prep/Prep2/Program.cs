using System;

class Program
{
    static void Main(string[] args)
    {
        //This is prep 2
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }



        if (grade >= 70)
        {
            Console.WriteLine("You're passing the course! ");
        }

        else if (grade < 70)
        {
            Console.WriteLine("You're not passing the course. ");
        }

        if (letter == "A")
        {
            if (grade % 10 >= 7)
            {
                sign = "";
            }

            else if (grade % 10 < 7)
            {
                sign = "-";
            }
        }

        else if (letter == "F")
        {
            sign = "";
        }

        else
        {
            if (grade % 10 >= 7)
            {
                sign = "+";
            }

            else if (grade % 10 < 7)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}");
    }
}