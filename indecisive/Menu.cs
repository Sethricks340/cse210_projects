public class Menu 
{
    public Menu()
    {

    }

    public void Display()
    {
        // Console.Clear();
        Console.WriteLine("Welcome to the Indecisive Program! ");

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
                    Console.WriteLine("Please enter your 4-digit ID: ");
                    int ID = Console.Read();
                    break;

                //New User
                case "2":
                    Console.WriteLine("You chose 2");
                    break;

                //Quit
                case "3":
                    Environment.Exit(0);
                    break;
            }
            response = "0";



        }
    }
}