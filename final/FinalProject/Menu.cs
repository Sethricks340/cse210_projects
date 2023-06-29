public class Menu 
{
    FileHandler _filehandler = new FileHandler();
    Options _options = new Options();
    Menu _menu = new Menu();

    public void Display()
    {   
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Welcome to the Indecisive Date Program! ");

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
                    int ID = int.Parse(Console.ReadLine());

                    if (_filehandler.CheckIDExists(ID))
                    {
                        Console.WriteLine("This ID exists in the ID file");
                        // Menu _menu = new Menu();
                        _menu.ActivityMenu();
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
                    ID = int.Parse(Console.ReadLine());
                    _filehandler.AddID(ID);
                    break;

                //Quit
                case "3":
                    Environment.Exit(0);
                    break;
            }
            response = "0";
        }
    }

    public void ActivityMenu()
    {
        string response = "";
        string[] options = {"1", "2", "3", "4", "5", "6", "7", "8"};
        while(response != "8")
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
                Console.WriteLine("7. Save");
                Console.WriteLine("8. Quit");

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
                    break;

                //See inputed options
                case "6":
                    // Menu _menu = new Menu();
                    _menu.ListOptionsMenu();
                    break;

                //Save
                case "7":
                    break;

                //Quit
                case "8":
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
                Console.WriteLine("3. List All Sit Down Restaurant");
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
                    _options.AddFastFood();
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










}