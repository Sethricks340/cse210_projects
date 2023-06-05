public class Listing : Mindfulness
{
    private List<string> _prompts = new List<string>();
    private List<string> _responses = new List<string>();

    public Listing()
    {
        _prompts.Add("Who are people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add("Who are people that you have helped this week? ");
        _prompts.Add("When have you felt the Holy Ghost this month? ");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void DisplayListingPrompt()
    {
        Random random = new Random();
        var randomNumber = random.Next(1, _prompts.Count);
        string currentPrompt = _prompts[randomNumber];
        Console.WriteLine($"\nList as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {currentPrompt} ---");
        Console.Write("You may begin in: ");
        base.CountFromFive();
    }

    public void AddResponses()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        Console.Write("\n");
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _responses.Add(response);
            
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_responses.Count} items! ");
    }

}