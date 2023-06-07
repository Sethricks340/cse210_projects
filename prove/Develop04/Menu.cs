public class Menu
{
    private int _breathingCount = 0;
    private int _reflectionCount = 0;
    private int _listingCount = 0;
    public void Display()
    {

        string response = "";
        string[] options = {"1", "2", "3", "4"};
        while(response != "4")
        {
            Console.Clear();
            while(options.Contains(response)==false)
            {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. See activity count record");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            
            response = Console.ReadLine();
            }

            switch(response)
            {
                case "1":
                    Console.Clear();
                    Breathing breathing = new Breathing();
                    breathing.SetStartMessage($"Welcome to the Breathing Activity!\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.");
                    breathing.SetActivityType("breathing activity");
                    breathing.PrintStartMessage();
                    breathing.PromptDuration();
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    breathing.Pause();
                    breathing.BreathInAndOut();
                    breathing.PrintEndMessage();
                    breathing.Pause();
                    _breathingCount += 1;
                    break;

                case "2":
                    Console.Clear();
                    Reflection reflection = new Reflection();
                    reflection.SetStartMessage($"Welcome to the Reflection Activity!\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflection.SetActivityType("reflection activity");
                    reflection.PrintStartMessage();
                    reflection.PromptDuration();
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    reflection.Pause();
                    reflection.DisplayPrompt();
                    reflection.PrintEndMessage();
                    reflection.Pause();
                    _reflectionCount += 1;
                    break;

                case "3":
                Console.Clear();
                    Listing listing = new Listing();
                    listing.SetStartMessage($"Welcome to the listing Activity!\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.SetActivityType("listing activity");
                    listing.PrintStartMessage();
                    listing.PromptDuration();
                    Console.Clear();
                    Console.WriteLine("Get ready...");
                    listing.Pause();
                    listing.DisplayListingPrompt();
                    listing.AddResponses();
                    listing.PrintEndMessage();
                    listing.Pause();
                    _listingCount += 1;
                    break;
                
                case "4":
                    Mindfulness mindfulness = new Mindfulness();
                    Console.Clear();
                    if (_breathingCount != 1){
                        Console.WriteLine($"You've done the breathing activity {_breathingCount} times! ");
                    }

                    else {
                        Console.WriteLine($"You've done the breathing activity {_breathingCount} time! ");
                    }
                    
                    if (_reflectionCount != 1){
                        Console.WriteLine($"You've done the reflecting activity {_reflectionCount} times! ");
                    }

                    else {
                        Console.WriteLine($"You've done the reflecting activity {_reflectionCount} time! ");
                    }

                    if (_listingCount != 1){
                        Console.WriteLine($"You've done the listing activity {_listingCount} times! ");
                    }

                    else {
                        Console.WriteLine($"You've done the listing activity {_listingCount} time! ");
                    }

                    Console.WriteLine("\nTaking you back to the main menu...");

                    mindfulness.Pause();

                    break;

                case "5":
                    Environment.Exit(0);
                    break;
            }
            response = "0";
        }
    }
}