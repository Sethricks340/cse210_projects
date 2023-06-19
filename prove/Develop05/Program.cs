using System;

class Program
{

    //To exceed the requirements in this program, the user is not able to quit unless they first save. Also, ny order of creating, listing, saving, and loading can be done without
    //any goals being lost. For example, if the user creates a goal and then tries to load a file, the goal they created will be added to the file that they load. 

    static void Main(string[] args)
    {
        Menu menu = new Menu();

        menu.Display();
    }
}