class Program
{

    //Things to work on next:
    //Random Generator menu -> menu class
        //*Random Generator methods -> options class
    static void Main(string[] args)
    {
        // Console.WriteLine("Is this uhhh... working?");

        Options options = new Options();
        Menu menu = new Menu(options);
        menu.Display();
    } 
}