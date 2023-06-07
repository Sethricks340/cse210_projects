public class Reflection : Mindfulness
{
    private List<string> _prompts = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();
    
    public Reflection()
    {
        _prompts.Add("Think of a time when you stoop up for someone else. ");
        _prompts.Add("Think of a time when you did something really difficult. ");
        _prompts.Add("Think of a time when you helped someone in need. ");
        _prompts.Add("Think of a time when you did something truly selfless. ");

        _reflectionQuestions.Add("Why was this experience meaningful to you? ");
        _reflectionQuestions.Add("Have you ever done anything like this before? ");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");
    }

    public void DisplayPrompt()
    {
        Random random = new Random();
        var randomNumber = random.Next(1, _prompts.Count);
        string currentPrompt = _prompts[randomNumber];
        Console.WriteLine($"\nConsider the following prompt:");
        Console.WriteLine($"\n--- {currentPrompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.CountFromFive();
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine($"> {_reflectionQuestions[randomNumber]}");
            base.Pause();
            base.Pause();

            currentTime = DateTime.Now;
            Random random2 = new Random();
            randomNumber = random2.Next(1, _prompts.Count);
        }
    }    
}