// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn", "Brandon Sanderson");

mistborn.Display();

Book theBookOfMormon = new Book("The Book of Mormon", "God");

theBookOfMormon.Display();

Console.WriteLine(mistborn.IsAvailable());