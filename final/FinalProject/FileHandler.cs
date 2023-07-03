public class FileHandler
{
    Options _options;
    public FileHandler(){}
    public FileHandler(Options options)
    {
        _options = options;
    }

    public void Save(string ID)
    {
        string IDFile = $"{ID}.txt";
        using (StreamWriter outputFile = new StreamWriter(IDFile, true))
        {
            List<Activity> activities = _options.GetActivities();
            if (activities.Count != 0)
            {
                foreach (var activity in activities)
                {
                    outputFile.WriteLine($"{activity.Stringify()}");
                }
            }

            List<Restaurant> restaurants = _options.GetRestaurants();
            if (restaurants.Count != 0)
            {
                foreach (var restaurant in restaurants)
                {
                    outputFile.WriteLine($"{restaurant.Stringify()}");
                }
            }
        }
    }
    public void Load()
    {
        //Take info from the ID file, and load it into the options lists
    }

    public bool CheckIDExists(string ID)
    {
        bool exists = false;
        string IDFile = "ID.txt";
        
        string[] lines = System.IO.File.ReadAllLines(IDFile);

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");
            string FileID = parts[0];
            
            if (FileID == ID)
            {
                exists = true;
            }
        }
        return exists;
    }

    public void AddID(string ID, string name)
    {
        Console.Clear();
        FileHandler _fileHandler = new FileHandler();
        if (_fileHandler.CheckIDExists(ID))
        {
            Console.WriteLine($"Sorry, the ID {ID} exists already. ");
        }

        else
        {
            string IDFile = "ID.txt";
            using (StreamWriter outputFile = new StreamWriter(IDFile, true))
            {
                outputFile.WriteLine($"{ID}|{name}"); 
            }

            string personalIDFile = $"{ID}.txt";
            using (StreamWriter outputFile = new StreamWriter(personalIDFile, true))
            {
                outputFile.WriteLine($"{name}"); 
            }
            Console.WriteLine($"Your ID has been created! ");
            Console.WriteLine($"\n(Press enter to continue)");
            Console.ReadLine();
            Console.Clear();
        }
    }
}