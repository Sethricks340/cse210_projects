public class Mindfulness
{
    protected string _startMessage = "if this start message is on the screen, you did it wrong.";
    protected string _endMessage = "if this end message is on the screen, you did it wrong.";
    protected int _duration = 0;
    protected string _activityType = "";

    public Mindfulness()
    {

    }

    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }

    public void SetActivityType(string activityType)
    {
        _activityType = activityType;
    }

    public void PrintStartMessage()
    {
        Console.WriteLine($"{_startMessage}");
    }
    public void PrintEndMessage()
    {
        Console.WriteLine($"\nGood Job!! ");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityType}!");
    }
    public void PromptDuration()
    {
        Console.Write("\nHow long, in seconds, would you like your session to be? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public virtual void Pause()
    {
        for (int i = 0; i < 2; i++)
        {
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        }
    }

    public void CountFromFive()
    {
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }


}