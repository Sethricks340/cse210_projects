using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Prompt prompt = new Prompt();
        //prompt.DisplayRandomPrompt();
        //prompt.PrintRandomPrompt();
    
        Entry entry = new Entry(prompt);
        Journal journal = new Journal();
        //string filename = journal.Load();
        // entry.WritePrompt(journal);
        // // entry.WritePrompt(journal);
        //journal.SaveJournal(filename);
        // journal.DisplayJournal(filename);
        Menu menu = new Menu(entry, journal);
        menu.Display();
    } 
}