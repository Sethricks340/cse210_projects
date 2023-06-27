public class Menu 
{
    FileHandler _filehandler = new FileHandler();
    Options _options = new Options();

    public void Display()
    {   
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
                        Menu _menu = new Menu();
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
        string[] options = {"1", "2", "3", "4", "5", "6", "7"};
        while(response != "7")
        {
            while(options.Contains(response)==false)
            {
                Console.WriteLine($"\nPlease select one of the following options: ");
                Console.WriteLine("1. Add Fast Food");
                Console.WriteLine("2. Add Sit Down Restaurant");
                // Console.WriteLine("3. Add Soda Shop");
                // Console.WriteLine("4. Add Treat");
                Console.WriteLine("3. Add Indoor Activity");
                Console.WriteLine("4. Add Outdoor Activity");
                Console.WriteLine("5. Go to Random Generator");
                Console.WriteLine("6. Save");
                Console.WriteLine("7. Quit");

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
                
                // //Add Soda Shop
                // case "3":
                //     break;

                // //Add Treat
                // case "4":
                //     break;
                
                //Add Indoor Activity
                case "3":
                    break;
                
                //Add Outdoor Activity
                case "4":
                    _options.AddOutSideActivity();
                    break;
                
                //Go to Random Generator
                case "5":
                    break;

                //Save
                case "6":
                    break;

                //Quit
                case "7":
                    Environment.Exit(0);
                    break;
            }
            response = "0";
        }
    }










}