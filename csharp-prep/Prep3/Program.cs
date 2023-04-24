using System;

class Program
{
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();
    float guess;
    int count;
    string response = "yes";
    int number = -1;

while (response == "yes")
{
number = randomGenerator.Next(1, 2);
count = 0;
    do
    {
        Console.Write("What is your guess? ");
        guess = float.Parse(Console.ReadLine());

        if (guess > number){
            Console.WriteLine("Lower");}

        else if (guess < number){
            Console.WriteLine("Higher");}

    count += 1;
    } while (number != guess);

    Console.WriteLine("You guessed it! ");

    if (count == 1){
    Console.WriteLine($"It took you {count} guess! ");}

    else {Console.WriteLine($"It took you {count} guesses! ");}

    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();

}
    } 
}