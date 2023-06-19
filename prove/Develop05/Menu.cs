public class Menu
{
    private List<Goal> _goals = new List<Goal>();
    Filehandler _filehandler = new Filehandler();
    private bool _saved = false;
    private bool _loaded = false;
    string filename = "";
    private int i;
    public void Display()
    {
        string response = "";
        string[] options = {"1", "2", "3", "4", "5", "6"};
        int totalPoints = 0;

        while (response != "6")
        {
            Console.Clear();
            while(options.Contains(response)==false)
            {
                Console.Clear();
                Console.WriteLine($"You have {totalPoints} points");
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu: ");
                    
                response = Console.ReadLine(); 
            }

            switch(response)
            {
                //Create New Goal
                case "1":

                    _saved = false;
                    string goalType = "";
                    string[] goalOptions = {"1", "2", "3"};

                    while(goalOptions.Contains(goalType)==false)
                    {
                        Console.WriteLine("The types of Goals are:");
                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. Checklist Goal");
                        Console.Write("Which type of goal would you like to create? ");
                        goalType = Console.ReadLine(); 
                    }

                    switch(goalType)
                    {
                        //Create a simple goal
                        case "1":
                            SimpleGoal simpleGoal = new SimpleGoal();
                            Console.Write("What is the name of your goal? ");
                            string goalName = Console.ReadLine(); 
                            simpleGoal.SetName(goalName);
                            Console.Write("What is a short description of it? ");
                            string goalDescription = Console.ReadLine();
                            simpleGoal.SetDescription(goalDescription);
                            Console.Write("What is the amount of points associated with this goal? ");
                            int goalPoints = int.Parse(Console.ReadLine());
                            simpleGoal.SetPoints(goalPoints);
                            _goals.Add(simpleGoal);
                            break;

                        //Create a eternal goal
                        case "2":
                            EternalGoal eternalGoal = new EternalGoal();
                            Console.Write("What is the name of your goal? ");
                            goalName = Console.ReadLine(); 
                            eternalGoal.SetName(goalName);
                            Console.Write("What is a short description of it? ");
                            goalDescription = Console.ReadLine();
                            eternalGoal.SetDescription(goalDescription);
                            Console.Write("What is the amount of points associated with this goal? ");
                            goalPoints = int.Parse(Console.ReadLine());
                            eternalGoal.SetPoints(goalPoints);
                            _goals.Add(eternalGoal);
                            break;

                        //Create a checklist goal
                        case "3":
                            CheckListGoal checkListGoal = new CheckListGoal();
                            Console.Write("What is the name of your goal? ");
                            goalName = Console.ReadLine(); 
                            checkListGoal.SetName(goalName);
                            Console.Write("What is a short description of it? ");
                            goalDescription = Console.ReadLine();
                            checkListGoal.SetDescription(goalDescription);
                            Console.Write("What is the amount of points associated with this goal? ");
                            goalPoints = int.Parse(Console.ReadLine());
                            checkListGoal.SetPoints(goalPoints);
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int timesToComplete = int.Parse(Console.ReadLine());
                            checkListGoal.SetTimesToComplete(timesToComplete);
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonus = int.Parse(Console.ReadLine());
                            checkListGoal.SetBonus(bonus);
                            _goals.Add(checkListGoal);
                            break;
                    }
                    break;

                //List Goals
                case "2":

                    if (_goals.Count > 0)
                    {
                        Console.WriteLine("The goals are: ");
                        i = 1;
                        foreach (var goal in _goals)
                        {
                            Console.Write($"{i}. ");
                            goal.DisplayGoal();
                            i += 1;    
                        }
                        Console.Write("(Press enter to continue) ");
                        Console.ReadLine();
                    }

                    else 
                    {
                        Console.WriteLine("There are no current goals to list.");
                        Console.Write("(Press enter to continue) ");
                        Console.ReadLine();
                    }
                    break;
                //Save Goals
                case "3":
                    if (_goals.Count > 0)
                    {
                        if (!_saved)
                        {
                            Console.Write("What is the file name for the goal file? ");
                            filename = Console.ReadLine();
                            totalPoints = _filehandler.Save(totalPoints, _goals, _loaded, filename);
                            Console.WriteLine($"{filename} saved and loaded.");
                            Console.Write("(Press enter to continue) ");
                            Console.ReadLine();
                            _saved = true;
                        }

                        else 
                        {
                            Console.WriteLine("You've already saved");
                            Console.Write("(Press enter to continue) ");
                            Console.ReadLine();
                        }
                    }

                    else 
                    {
                        Console.WriteLine("There are no current goals to save.");
                        Console.Write("(Press enter to continue) ");
                        Console.ReadLine();
                    }
                    break;

                //Load Goals
                case "4":

                    if (! _loaded)
                    {
                        Console.Write("What is the file name for the goal file? ");
                        filename = Console.ReadLine();
                        totalPoints = _filehandler.Load(totalPoints, _goals, filename);
                    }

                    else 
                    {
                        Console.WriteLine("You've already loaded.");
                        Console.Write("(Press enter to continue) ");
                        Console.ReadLine();
                    }
                    _loaded = true;
                    _saved = false;
                    break;

                //Record Event
                case "5":
                    if (_goals.Count > 0)
                    {
                        Console.WriteLine("The goals are:");
                        i = 1;
                        foreach (var goal in _goals)
                        {
                            Console.Write($"{i}. ");
                            Console.WriteLine(goal.GetName());
                            i += 1;  
                        }
                        Console.Write("Which goal did you accomplish? ");
                        i = int.Parse(Console.ReadLine());
                        i -= 1;
                        if (_goals[i].GetComplete() == false)
                        {
                            _goals[i].SetComplete();
                            totalPoints += _goals[i].GetPoints();
                        }

                        else
                        {
                            Console.WriteLine("This goal is already completed!");
                            Console.Write("(Press enter to continue) ");
                            Console.ReadLine();
                        }
                        _saved = false;
                    }

                    else 
                    {
                        Console.WriteLine("There are no current goals to record.");
                        Console.Write("(Press enter to continue) ");
                        Console.ReadLine();
                    }
                    break;

                //Quit
                case "6":
                    if (_goals.Count > 0)
                    {
                        if (!_saved)
                        {
                            Console.Write("You haven't saved. Are you sure you want to without saving? (Enter 'yes' to continue) ");
                            string quit = Console.ReadLine();

                            if (quit.ToLower() == "yes")
                            {
                                Environment.Exit(0);
                            }

                            else
                            {
                                Console.Write("What is the file name for the goal file? ");
                                filename = Console.ReadLine();
                                totalPoints = _filehandler.Save(totalPoints, _goals, _loaded, filename);
                                Console.WriteLine("Your responses have been saved.");
                                Environment.Exit(0);
                            }
                        }

                        else
                        {
                            Environment.Exit(0);
                        }
                    }

                    else 
                    {
                        Environment.Exit(0);
                    }

                    break;
            }
            response = "0";
        }
    }

    public void Load()
    {

    }


}