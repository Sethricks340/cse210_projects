public class Menu 
{
    Options _options = new Options();
    FileHandler _filehandler;
    public Menu(Options options)
    {
        _options = options;
        _filehandler = new FileHandler(_options);
    }

    public void Display()
    {   
        Console.Clear();
        Console.WriteLine("Welcome to the Indecisive Date App! ");

        string response = "";
        string[] options = {"1", "2", "3"};
        while(response != "3")
        {
            while(options.Contains(response)==false)
            {
                Console.WriteLine($"\nPlease select one of the following options: ");
                Console.WriteLine("1. Returning user");
                Console.WriteLine("2. New User");
                Console.WriteLine("3. Quit");

                response = Console.ReadLine() ?? "";
            }

            switch(response)
            {
                //Returning user
                case "1":
                    Console.Clear();
                    Console.WriteLine("Please enter your number ID: ");
                    string ID = Console.ReadLine();

                    if (_filehandler.CheckIDExists(ID))
                    {
                        string[] lines = System.IO.File.ReadAllLines($"{ID}.txt");

                        _filehandler.Load(ID);

                        string userName = lines[0];
                        Console.WriteLine($"Welcome {userName}, your past info has been loaded :) ");
                        Menu _menu = new Menu(_options);
                        _menu.ActivityMenu(ID, userName);
                    }
                    
                    else
                    {
                        Console.WriteLine($"Sorry, the ID {ID} does not exist. ");
                    }
                    break;

                //New User
                case "2":
                    Console.Clear();
                    Console.WriteLine("Please create your number ID: ");
                    ID = Console.ReadLine();
                    Console.WriteLine("What is your name? ");
                    string name = Console.ReadLine();
                    _filehandler.AddID(ID, name);
                    break;

                //Quit
                case "3":
                    Environment.Exit(0);
                    break;
            }
            response = "0";
        }
    }

    public void ActivityMenu(string ID, string name)
    {
        string response = "";
        string[] options = {"1", "2", "3", "4", "5", "6", "7"};
        while(response != "7")
        {
            while(options.Contains(response)==false)
            {
                Console.WriteLine($"\nPlease select one of the following options: ");
                Console.WriteLine("1. Add Fast Food");
                Console.WriteLine("2. Add Sit Down Restaurant");
                Console.WriteLine("3. Add Indoor Activity");
                Console.WriteLine("4. Add Outdoor Activity");
                Console.WriteLine("5. Go to Random Generator");
                Console.WriteLine("6. See Inputed Options");
                Console.WriteLine("7. Save and Quit");

                response = Console.ReadLine() ?? "";
            }

            switch(response)
            {
                //Add Fast Food
                case "1":
                    _options.AddFastFood();
                    break;

                //Add Sit Down Restaurant
                case "2":
                    _options.AddSitDownFood();
                    break;                
                //Add Indoor Activity
                case "3":
                    _options.AddInsideActivity();
                    break;
                
                //Add Outdoor Activity
                case "4":
                    _options.AddOutsideActivity();
                    break;
                
                //Go to Random Generator
                case "5":
                    Menu _menu = new Menu(_options);
                    _menu.RandomGeneratorMenu();
                    break;

                //See inputed options
                case "6":
                    _menu = new Menu(_options);
                    _menu.ListOptionsMenu();
                    break;

                //Save and Quit
                case "7":
                    _filehandler.Save(ID, name);
                    Environment.Exit(0);
                    break;
            }
            response = "0";
        }
    }

    public void ListOptionsMenu()
    {
        Console.Clear();
        string response = "";
        string[] options = {"1", "2", "3", "4", "5", "6", "7"};
        while(response != "7")
        {
            while(options.Contains(response)==false)
            {
                
                Console.WriteLine($"\nHere is the listing options menu: ");
                Console.WriteLine($"Please select one of the following options: ");
                Console.WriteLine("1. List All Restaurants");
                Console.WriteLine("2. List All Fast Food Restaurants");
                Console.WriteLine("3. List All Sit Down Restaurants");
                Console.WriteLine("4. List All Activities");
                Console.WriteLine("5. List All Indoor Activities");
                Console.WriteLine("6. List All Outdoor Activities");
                Console.WriteLine("7. Go back");

                response = Console.ReadLine() ?? "";
            }

            switch(response)
            {
                //List all restaurants 
                case "1":
                    _options.ListAllRestaurants();
                    break;

                //List all fast food restaurants 
                case "2":
                    _options.ListFastFoodRestaurants();
                    break;

                //List all sit down restaurants
                case "3":
                    _options.ListSitDownRestaurants();
                    break;

                //List all activities
                case "4":
                    _options.ListAllActivities();
                    break;

                //List all indoor activities
                case "5":
                    _options.ListIndoorActivities();
                    break;

                //List all outdoor activities
                case "6":
                    _options.ListOutdoorActivities();
                    break;

                //Quit options menu
                case "7":
                    Console.Clear();
                    break;
            }
            response = (response != "7") ? "0" : "7";
        }
    }

    public void RandomGeneratorMenu()
    {
        Console.Clear();
        string response = "";
        string[] options = {"1", "2", "3", "4", "5", "6", "7"};
        while(response != "7")
        {
            while(options.Contains(response)==false)
            {
                
                Console.WriteLine($"\nHere is the Random Generator menu: ");
                Console.WriteLine($"Please select one of the following options: ");
                Console.WriteLine("1. Generate Random Restaurant");
                Console.WriteLine("2. Generate Random Fast Food Restaurant");
                Console.WriteLine("3. Generate Random Sit Down Restaurant");
                Console.WriteLine("4. Generate Random Activity");
                Console.WriteLine("5. Generate Random Indoor Activity");
                Console.WriteLine("6. Generate Random Outdoor Activity");
                Console.WriteLine("7. Go back");

                response = Console.ReadLine() ?? "";
            }

            switch(response)
            {
                //Generate Random Restaurant
                case "1":
                    Console.Clear();
                    if (!_options.IsListEmpty("general Restaurant"))
                    {
                        Console.Clear();
                        Restaurant randomRestaurant = _options.ChooseRandomRestaurant();
                        Console.WriteLine("Here is your randomly generated restaurant! Enjoy!");
                        Console.WriteLine($"**{randomRestaurant.GetName()}");

                        Console.WriteLine(randomRestaurant.GetFoodItems().Count != 0 ? $"You could try this food!\n{randomRestaurant.ChooseRandomFood()}" : "");

                        Console.WriteLine(randomRestaurant.GetDrinkItems().Count != 0 ? $"You could try this drink!\n{randomRestaurant.ChooseRandomDrink()}" : "");
                        
                        //Check for reservation
                        if (randomRestaurant is SitDownRestaurant)
                        {
                            SitDownRestaurant sitDownRestaurant = (SitDownRestaurant)randomRestaurant;
                            bool needReservation = sitDownRestaurant.GetNeedReservation();
                            Console.WriteLine(needReservation ? $"Remember that you're going to need a reservation!" : $"You don't need a reservation!");
                        }

                        Console.WriteLine($"\n(Press enter to continue)");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Sorry, there are no inputted restaurants to generate from. ");
                    }
                    break;

                //Generate Random Fast Food Restaurant
                case "2":
                    Console.Clear();
                    if (!_options.IsListEmpty("Fast Food"))
                    {
                        Console.Clear();
                        FastFoodRestaurant randomFast = _options.ChooseRandomFastFood();;
                        Console.WriteLine("Here is your randomly generated fast food restaurant! Enjoy!");
                        Console.WriteLine($"**{randomFast.GetName()}");

                        Console.WriteLine(randomFast.GetFoodItems().Count != 0 ? $"You could try this food!\n{randomFast.ChooseRandomFood()}" : "");

                        Console.WriteLine(randomFast.GetDrinkItems().Count != 0 ? $"You could try this drink!\n{randomFast.ChooseRandomDrink()}" : "");

                        Console.WriteLine($"\n(Press enter to continue)");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Sorry, there are no inputted fast food restaurants to generate from. ");
                    }
                    break;

                //Generate Random Sit Down
                case "3":
                    Console.Clear();
                    if (!_options.IsListEmpty("Sit Down"))
                    {
                        Console.Clear();
                        SitDownRestaurant sitDown = _options.ChooseRandomSitDown();
                        Console.WriteLine("Here is your randomly generated sit down restaurant! Enjoy!");
                        Console.WriteLine($"**{sitDown.GetName()}");

                        Console.WriteLine(sitDown.GetFoodItems().Count != 0 ? $"You could try this food!\n{sitDown.ChooseRandomFood()}" : "");

                        Console.WriteLine(sitDown.GetDrinkItems().Count != 0 ? $"You could try this drink!\n{sitDown.ChooseRandomDrink()}" : "");
                        
                        bool reservation = sitDown.GetNeedReservation();
                        Console.WriteLine(reservation ? $"Remember that you're going to need a reservation!" : $"You don't need a reservation!");

                        Console.WriteLine($"\n(Press enter to continue)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, there are no inputted sit down restaurants to generate from. ");
                    }
                    break;

                //Generate Random Activity
                case "4":
                    Console.Clear();
                    if (!_options.IsListEmpty("general activity"))
                    {
                        Console.Clear();
                        Activity activity = _options.ChooseRandomActivity();
                        Console.WriteLine("Here is your randomly generated activity! ");
                        Console.WriteLine($"**{activity.GetName()}");

                        if (activity.GetNeededItems().Count != 0)
                        {
                            List<string> _neededItems = activity.GetNeededItems();
                            Console.WriteLine($"You will need the following items:");
                            
                            foreach (string item in _neededItems)
                            {
                                Console.Write(_neededItems.IndexOf(item) != _neededItems.Count - 1 ? $"{item}, " : $"{item}\n");
                            }
                        }

                        if (activity is OutsideActivity)
                        {
                            OutsideActivity outside = (OutsideActivity)activity;
                            string time = outside.GetTime();
                            Console.WriteLine(time != "" ? $"Time this activity is avilable: {time}" : "");
                        }

                        Console.WriteLine($"\n(Press enter to continue)");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Sorry, there are no inputted activities to generate from. ");
                    }
                    break;

                //Generate Random Indoor Activity
                case "5":
                    Console.Clear();
                    if (!_options.IsListEmpty("indoor activity"))
                    {
                        Console.Clear();
                        InsideActivity indoor = _options.ChooseRandomIndoor();
                        Console.WriteLine("Here is your randomly generated indoor activity! ");
                        Console.WriteLine($"**{indoor.GetName()}");

                        if (indoor.GetNeededItems().Count != 0)
                        {
                            List<string> _neededItems = indoor.GetNeededItems();
                            Console.WriteLine($"You will need the following items:");
                            
                            foreach (string item in _neededItems)
                            {
                                Console.Write(_neededItems.IndexOf(item) != _neededItems.Count - 1 ? $"{item}, " : $"{item}\n");
                            }
                        }

                        Console.WriteLine($"\n(Press enter to continue)");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Sorry, there are no inputted indoor activities to generate from. ");
                    }
                    break;

                //Generate Random Outdoor Activity
                case "6":
                    Console.Clear();
                    if (!_options.IsListEmpty("outdoor activity"))
                    {
                        Console.Clear();
                        OutsideActivity outdoor = _options.ChooseRandomOutdoor();
                        Console.WriteLine("Here is your randomly generated outdoor activity! ");
                        Console.WriteLine($"**{outdoor.GetName()}");

                        if (outdoor.GetNeededItems().Count != 0)
                        {
                            List<string> _neededItems = outdoor.GetNeededItems();
                            Console.WriteLine($"You will need the following items:");
                            
                            foreach (string item in _neededItems)
                            {
                                Console.Write(_neededItems.IndexOf(item) != _neededItems.Count - 1 ? $"{item}, " : $"{item}\n");
                            }
                        }
                        
                        string outdoorTime = outdoor.GetTime();
                        Console.WriteLine(outdoorTime != "" ? $"Time this activity is avilable: {outdoorTime}" : "");

                        Console.WriteLine($"\n(Press enter to continue)");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Sorry, there are no inputted outdoor activities to generate from. ");
                    }
                    break;

                //Quit Random Generator menu
                case "7":
                    Console.Clear();
                    break;
            }
            response = (response != "7") ? "0" : "7";
        }
    }







}