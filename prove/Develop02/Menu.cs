public class Menu
{
    private Entry _entry;
    private Journal _journal;
    private String filename = "";
    private bool save;
    public Menu(Entry entry, Journal journal)
    {
        _entry = entry;
        _journal = journal;
    }

    public void Display()
    {
        Console.WriteLine("\nWelcome to the journal program! ");

        string response = "";
        string[] options = {"1", "2", "3", "4", "5"};
        while(response != "5")
        {
            while(options.Contains(response)==false)
            {
            Console.WriteLine($"\nPlease select one of the following choices: ");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit ");
            
            response = Console.ReadLine();
            }

            switch(response)
            {
                case "5":
                    if (!save)
                    {
                        Console.Write("You haven't saved. Are you sure you want to without saving? (Enter 'yes' to continue) ");
                        string quit = Console.ReadLine();

                        if (quit == "yes")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            if (filename == "")
                            {
                                filename = _journal.Load();
                            }

                            _journal.SaveJournal(filename);
                            Console.WriteLine("Your responses have been saved.");
                            Environment.Exit(0);
                        }
                    }

                    else
                    {
                        Environment.Exit(0);
                    }

                    break;
                
                case "1":
                    _entry.WritePrompt(_journal);
                    save = false;
                    break;

                case "2":
                    bool fileExist = File.Exists(filename);
                    if (! fileExist)
                    {
                        filename = _journal.Load();
                    }

                    
                    _journal.DisplayJournal(filename);
                    break;

                case "3":
                    filename = _journal.Load();
                    break;

                case "4":
                    if (filename == "")
                    {
                        filename = _journal.Load();
                    }
                    _journal.SaveJournal(filename);
                    save = true;
                    break;
            }
            response = "0";
        }




    }
}