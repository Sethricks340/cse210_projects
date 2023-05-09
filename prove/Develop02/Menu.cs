public class Menu
{
    private Entry _entry;
    private Journal _journal;
    private String filename = "";
    public Menu(Entry entry, Journal journal)
    {
        _entry = entry;
        _journal = journal;
    }

    public void Display()
    {
        Console.WriteLine("Welcome to the journal program! ");

        int response = 0;
        int[] options = {1, 2, 3, 4, 5};
        while(response != 5)
        {
            while(options.Contains(response)==false)
            {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            
            response = int.Parse(Console.ReadLine());
            }

            switch(response)
            {
                case 5:
                    Environment.Exit(0);
                    break;
                
                case 1:
                    _entry.WritePrompt(_journal);
                    break;

                case 2:
                    if (filename == "")
                    {
                        filename = _journal.Load();
                    }

                    else
                    {
                    _journal.DisplayJournal(filename);
                    }
                    break;

                case 3:
                    filename = _journal.Load();
                    break;

                case 4:
                    if (filename == "")
                    {
                        filename = _journal.Load();
                    }

                    _journal.SaveJournal(filename);
                    break;
            }
            response = 0;
        }




    }
}