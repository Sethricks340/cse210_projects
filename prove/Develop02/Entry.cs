public class Entry
{
    private Prompt _prompt;

    public Entry(Prompt prompt)
    {   
        _prompt = prompt;
    }

    public void WritePrompt()
    {
        _prompt.PrintRandomPrompt();
        string response = Console.ReadLine();
    }
}