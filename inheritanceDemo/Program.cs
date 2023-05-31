// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Loanable harryPotter = new Loanable();
harryPotter.CheckOut();
harryPotter.Display();

Dvd theWayOfKings = new Dvd("The Way of Kings");
theWayOfKings.CheckOut();
//the method is looked for locally, then if it doesn't exist it goes up the change
theWayOfKings.Display();
theWayOfKings.CheckIn();
theWayOfKings.Display();

Book theBookOfMormon = new Book("The Book of Mormon", "abcd", 1234);
theBookOfMormon.CheckIn();
theBookOfMormon.Display();
