public class Prompt
{
    List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("How was your day? Why? ");
        _prompts.Add("What is something that you did today that you are truly proud of? ");
        _prompts.Add("What is something that you would like to do tomorrow? ");
        _prompts.Add("Did you see anything beautiful today? What was it? ");
        _prompts.Add("What is a goal that you can set for tomorrow, based off of something that happened today? ");
    } 


    public string GetRandomPrompt()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_prompts.Count);
        string randomPrompt = _prompts[randomNumber];
        return randomPrompt;
    }

}