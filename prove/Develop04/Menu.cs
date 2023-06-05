public class Menu
{
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
            Console.WriteLine("4. Quit");
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
                    // breathing.Pause();
                    breathing.BreathInAndOut();
                    breathing.PrintEndMessage();
                    breathing.Pause();
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
                    break;

                case "4":
                    Environment.Exit(0);
                    break;
            }
            response = "0";
        }
    }
}