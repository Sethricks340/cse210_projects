public class FileHandler
{
    Options _options;
    public FileHandler(){}
    public FileHandler(Options options)
    {
        _options = options;
    }

    public void Save(string ID, string name)
    {
        string IDFile = $"{ID}.txt";
        using (StreamWriter outputFile = new StreamWriter(IDFile, false))
        {
            outputFile.WriteLine($"{name}");
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
    public void Load(string ID)
    {
        //Take info from the ID file, and load it into the options lists
        string IDFile = $"{ID}.txt";
        string[] lines = System.IO.File.ReadAllLines(IDFile);
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");
            string type = parts[0];

            if (type == "Inside")
            {
                InsideActivity inside = new InsideActivity();
                inside.SetName(parts[1]);

                if (parts[2] != "")
                {
                    string[] items = parts[2].Split(",");
                    for (int j = 0; j < items.Length; j++)
                    {
                        inside.AddNeededItem(items[j]);
                    }
                }
                _options.AppendIndoorList(inside);
                Activity activity = (Activity)inside;
                _options.AppendActivityList(inside);
            }

            if (type == "Outside")
            {
                OutsideActivity outside = new OutsideActivity();
                outside.SetName(parts[1]);

                if (parts[2] != "")
                {
                    string[] items = parts[2].Split(",");
                    for (int j = 0; j < items.Length; j++)
                    {
                        outside.AddNeededItem(items[j]);
                    }
                }

                if (parts[3] != "")
                {
                    outside.SetTime(parts[3]);
                }
                _options.AppendOutdoorList(outside);
                Activity activity = (Activity)outside;
                _options.AppendActivityList(outside);
            }

            if (type == "FastFood")
            {
                FastFoodRestaurant fastFood = new FastFoodRestaurant();
                fastFood.SetName(parts[1]);

                if (parts[2] != "")
                {
                    string[] foodItems = parts[2].Split(",");
                    for (int j = 0; j < foodItems.Length; j++)
                    {
                        fastFood.SetFoodItem(foodItems[j]);
                    }
                }

                if (parts[3] != "")
                {
                    string[] drinkItems = parts[3].Split(",");
                    for (int j = 0; j < drinkItems.Length; j++)
                    {
                        fastFood.SetDrinkItems(drinkItems[j]);
                    }

                }
                _options.AppendFastFoodList(fastFood);
                Restaurant restaurant = (Restaurant)fastFood;
                _options.AppendRestaurantList(fastFood);
            }

            if (type == "SitDown")
            {
                SitDownRestaurant sitDown = new SitDownRestaurant();
                sitDown.SetName(parts[1]);

                if (parts[2] != "")
                {
                    string[] foodItems = parts[2].Split(",");
                    for (int j = 0; j < foodItems.Length; j++)
                    {
                        sitDown.SetFoodItem(foodItems[j]);
                    }
                }

                if (parts[3] != "")
                {
                    string[] drinkItems = parts[2].Split(",");
                    for (int j = 0; j < drinkItems.Length; j++)
                    {
                        sitDown.SetDrinkItems(drinkItems[j]);
                    }

                }

                bool reservation = parts[4] == "True" ? true : false;
                sitDown.SetNeedReservation(reservation);

                _options.AppendSitDownList(sitDown);
                SitDownRestaurant restaurant = (SitDownRestaurant)sitDown;
                _options.AppendRestaurantList(sitDown);
            }
        }
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