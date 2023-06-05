public class Breathing : Mindfulness
{

    public Breathing()
    {
    }

    public void BreathInAndOut()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("\nBreathe in...");
            base.CountFromFive();
        
            Console.Write("\nNow breathe out...");
            base.CountFromFive();
            
            currentTime = DateTime.Now;
        }
        Console.WriteLine("");
    }
}