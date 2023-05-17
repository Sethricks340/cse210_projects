// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nHello, World!");


Player neymar = new Player("Neymar jr.", 10, "Forward");
Player kobe = new Player("Kobe Bryant", 24);


kobe.SetPosition("Shooting Guard");

// neymar._name = "Neymar jr.";
// neymar._position = "Forward";
// neymar._jerseyNumber = 10;


// Console.WriteLine(kobe.Display());
// Console.WriteLine(neymar.Display());

Team awesomeSauce = new Team("Awesome Sauce");
awesomeSauce.AddPlayer(kobe);
awesomeSauce.AddPlayer(neymar);
awesomeSauce.SetWins(5);
awesomeSauce.SetLosses(500);
awesomeSauce.AddWin();
awesomeSauce.AddLoss();
awesomeSauce.DisplayRoster();