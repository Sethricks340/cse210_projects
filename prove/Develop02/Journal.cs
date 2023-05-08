public class Journal
{

    List<string> _entries = new List<string>();

    public Journal()
    {
    }

    public void StageJournal(string _entry)
    {
        // _entries.Add("This is an example string.");
        // _entries.Add("This is also an example string.");
        _entries.Add(_entry);
    }

    public void SaveJournal()
    {
        //foreach loop that saves every entry put in so far into the journal.txt file, 
        //And then deletes them all from the list in case the user writes and saves again, so that 
        //Things aren't saved twice in the file
        
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}