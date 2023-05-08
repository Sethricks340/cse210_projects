public class Entry
{
    private Prompt _prompt;

    public Entry(Prompt prompt)
    {   
        _prompt = prompt;
    }

    public void WritePrompt(Journal _journal)
    {
        string currentPrompt = _prompt.GetRandomPrompt();
        Console.Write(currentPrompt);
        string response = Console.ReadLine();
        String currentDateTime = DateTime.Now.ToString("MM/dd/yyyy");
        string fullEntry = $"Date: {currentDateTime}\nPrompt: {currentPrompt}\nResponse: {response}\n";
        _journal.StageJournal(fullEntry);
    }
}