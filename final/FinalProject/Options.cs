public class Options
{
    public List<Restaurant> _restaurants = new List<Restaurant>();
    public List<FastFoodRestaurant> _fastFoodRestaurants = new List<FastFoodRestaurant>();
    public List<SitDownRestaurant> _sitDownRestaurants = new List<SitDownRestaurant>();
    // public List<SodaShop> _sodaShops = new List<SodaShop>();
    // public List<Treat> _treat = new List<Treat>();
    public List<Activity> _activities = new List<Activity>();
    public List<InsideActivity> _indoorActivities = new List<InsideActivity>();
    public List<OutsideActivity> _outdoorActivities = new List<OutsideActivity>();
    
    public void AddRestaurant(string type)
    {
    }

    
    public void AddFastFood()
    {
        FastFoodRestaurant _fastFood = new FastFoodRestaurant();
        Console.WriteLine("What is the name of the fast food restaurant? ");
        _fastFood.SetName(Console.ReadLine());

        Console.WriteLine("Would you like to add food items? (yes or no) ");
        string response = Console.ReadLine();
        string done = "";

        while (response.ToLower() == "yes" && done.ToLower() != "done")
        {
            Console.WriteLine("Enter a food item, followed by enter. (type 'done' to exit)");
            done = Console.ReadLine();
            if (done.ToLower() != "done")
            {
                _fastFood.SetFoodItem(done);
            }
        }

        Console.WriteLine("Would you like to add drink items? (yes or no) ");
        response = Console.ReadLine();
        done = "";
        while (response.ToLower() == "yes" && done.ToLower() != "done")
        {
            Console.WriteLine("Enter a drink item, followed by enter. (type 'done' to exit)");
            done = Console.ReadLine();
            if (done.ToLower() != "done")
            {
                _fastFood.SetFoodItem(done);
            }
        }

        Console.Clear();
        _restaurants.Add(_fastFood);
        _fastFoodRestaurants.Add(_fastFood);

        //Got rid of... RIP
        //Desired food items
        //Desired drink items
    }

    public void AddSitDownFood()
    {
        SitDownRestaurant _sitDownRestaurant = new SitDownRestaurant();
        Console.WriteLine("What is the name of the sit-down restaurant? ");
        _sitDownRestaurant.SetName(Console.ReadLine());

        Console.WriteLine("Would you like to add food items? (yes or no) ");
        string response = Console.ReadLine();
        string done = "";

        while (response.ToLower() == "yes" && done.ToLower() != "done")
        {
            Console.WriteLine("Enter a food item, followed by enter. (type 'done' to exit)");
            done = Console.ReadLine();
            if (done.ToLower() != "done")
            {
                _sitDownRestaurant.SetFoodItem(done);
            }
        }

        Console.WriteLine("Would you like to add drink items? (yes or no) ");
        response = Console.ReadLine();
        done = "";
        while (response.ToLower() == "yes" && done.ToLower() != "done")
        {
            Console.WriteLine("Enter a drink item, followed by enter. (type 'done' to exit)");
            done = Console.ReadLine();
            if (done.ToLower() != "done")
            {
                _sitDownRestaurant.SetFoodItem(done);
            }
        }

        Console.WriteLine("Would you like to enter if a reservation is needed? (yes or no) ");
        response = Console.ReadLine();
        done = "";
        if (response.ToLower() == "yes")
        {
            Console.WriteLine("Is a reservation needed for this restaurant? (yes or no) ");
            done = Console.ReadLine();
            if (done.ToLower() == "yes")
            {
                _sitDownRestaurant.SetNeedResevation(true);
            }

            else
            {
                _sitDownRestaurant.SetNeedResevation(false);
            }
        }

        _restaurants.Add(_sitDownRestaurant);
        _sitDownRestaurants.Add(_sitDownRestaurant);
        Console.Clear();

        //Got rid of... RIP
        //Desired food items
        //Desired drink items
    }

    public void AddOutsideActivity()
    {
        OutsideActivity _outdoorActivity = new OutsideActivity();
        Console.WriteLine("What is the name of the outdoor activity? ");
        _outdoorActivity.SetName(Console.ReadLine());

        Console.WriteLine("Would you like to add needed items for this activity? (yes or no) ");
        string response = Console.ReadLine();
        string done = "";

        while (response.ToLower() == "yes" && done.ToLower() != "done")
        {
            Console.WriteLine("Enter a needed item, followed by enter. (type 'done' to exit)");
            done = Console.ReadLine();
            if (done.ToLower() != "done")
            {
                _outdoorActivity.AddNeededItem(done);
            }
        }

        Console.WriteLine("Would you like to add the time this activity can be done? (yes or no) ");
        response = Console.ReadLine();
        done = "";
        if (response.ToLower() == "yes")
        {
            Console.WriteLine("Enter the time this activity can be done. ");
            done = Console.ReadLine();
            if (done.ToLower() != "done")
            {
                _outdoorActivity.SetTime(done);
            }
        }

        Console.Clear();
        _activities.Add(_outdoorActivity);
        _outdoorActivities.Add(_outdoorActivity);
    }
    
    public void AddInsideActivity()
    {
        InsideActivity _insideActivity = new InsideActivity();
        Console.WriteLine("What is the name of the indoor activity? ");
        _insideActivity.SetName(Console.ReadLine());

        Console.WriteLine("Would you like to add needed items for this activity? (yes or no) ");
        string response = Console.ReadLine();
        string done = "";

        while (response.ToLower() == "yes" && done.ToLower() != "done")
        {
            Console.WriteLine("Enter a needed item, followed by enter. (type 'done' to exit)");
            done = Console.ReadLine();
            if (done.ToLower() != "done")
            {
                _insideActivity.AddNeededItem(done);
            }
        }

        Console.Clear();
        _activities.Add(_insideActivity);
        _indoorActivities.Add(_insideActivity);
    }



    public void ListAllActivities()
    {
        Console.Clear();
        Console.WriteLine("Here are all the activities! ");

        // foreach (Activity activity in _activities)
        // {
        //     Console.WriteLine(activity.GetName());
        // }

        foreach (Activity activity in _activities)
        {
            activity.Display();
        }
        Console.WriteLine($"\n(Press enter to continue)");
        Console.ReadLine();
        Console.Clear();

    }

    public void ListAllRestaurants()
    {
        Console.WriteLine("Here are all the restaurants! ");

        foreach (Restaurant restaurant in _restaurants)
        {
            Console.WriteLine(restaurant.GetName());
        }
    }
    public void ListFastFoodRestaurants()
    {
        Console.WriteLine("Here are all the fast food restaurants! ");

        foreach (FastFoodRestaurant restaurant in _fastFoodRestaurants)
        {
            Console.WriteLine(restaurant.GetName());
        }
    }

    public void ListSitDownRestaurants()
    {
        Console.WriteLine("Here are all the sit down restaurants! ");

        foreach (SitDownRestaurant restaurant in _sitDownRestaurants)
        {
            Console.WriteLine(restaurant.GetName());
        }
    }



























    public void AddActivity()
    {
    }
    
    // public Restaurant ChooseRandomRestaurant()
    // {
    // }
    // public Activity ChooseRandomActivity()
    // {
    // }
}