// See https://aka.ms/new-console-template for more information

Source source = new Source("None Were With Him", "http://www.churchofjesuschrist.org");

Console.WriteLine(source.Stringify());

Quote holland = new Quote("Elder Holand", "Because Jesus walked alone, we don't have to", source);

// Console.WriteLine(holland.GetQuote());

Board quoteboard = new Board();
// quoteboard.AddQuote(holland);
// quoteboard.GetRandomQuote();
// quoteboard.FindQuotesByAuthor("holland");
quoteboard.AddQuote(new Quote("Alma", "if ye have faith ye hope for things which are not seen, which are true.", new Source("Alma 32:21")));
quoteboard.AddQuote(new Quote("Alma", "Counsel with the Lord in all they doings, and he will direct thee for good.", new Source("Alma 37:37")));
quoteboard.AddQuote(new Quote("Alma", "Live in thanksgiving daily.", new Source("Alma 34:38")));
quoteboard.GetRandomQuote();

Menu _menu = new Menu(quoteboard);
_menu.Display();
