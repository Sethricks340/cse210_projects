public class Options
{
    public List<Restaurant> _restaurants = new List<Restaurant>();
    public List<FastFoodRestaurant> _fastFoodRestaurants = new List<FastFoodRestaurant>();
    public List<SitDownRestaurant> _sitDownRestaurants = new List<SitDownRestaurant>();
    public List<Activity> _activities = new List<Activity>();
    public List<InsideActivity> _indoorActivities = new List<InsideActivity>();
    public List<OutsideActivity> _outdoorActivities = new List<OutsideActivity>();
    
    public bool IsListEmpty(string listType)
    {
        bool empty = true;
        if (listType  == "Sit Down")
        {
            empty = _sitDownRestaurants.Count == 0 ? true : false; 
        }

        else if (listType == "Fast Food")
        {
            empty = _fastFoodRestaurants.Count == 0 ? true : false; 
        }

        else if (listType == "general Restaurant")
        {
            empty = _restaurants.Count == 0 ? true : false; 
        }

        else if (listType == "indoor activity")
        {
            empty = _indoorActivities.Count == 0 ? true : false; 
        }

        else if (listType == "outdoor activity")
        {
            empty = _outdoorActivities.Count == 0 ? true : false; 
        }

        else if (listType == "general activity")
        {
            empty = _outdoorActivities.Count == 0 ? true : false; 
        }
        return empty;
    }

    public void AppendRestaurantList(Restaurant restaurant)
    {
        _restaurants.Add(restaurant);
    }
    public void AppendFastFoodList(FastFoodRestaurant restaurant)
    {
        _fastFoodRestaurants.Add(restaurant);
    }
    public void AppendSitDownList(SitDownRestaurant restaurant)
    {
        _sitDownRestaurants.Add(restaurant);
    }
    public void AppendActivityList(Activity activity)
    {
        _activities.Add(activity);
    }
    public void AppendIndoorList(InsideActivity activity)
    {
        _indoorActivities.Add(activity);
    }
    public void AppendOutdoorList(OutsideActivity activity)
    {
        _outdoorActivities.Add(activity);
    }

    public List<Restaurant> GetRestaurants()
    {
        return _restaurants;
    }
    public List<Activity> GetActivities()
    {
        return _activities;
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
                _fastFood.SetDrinkItems(done);
            }
        }

        Console.Clear();
        _restaurants.Add(_fastFood);
        _fastFoodRestaurants.Add(_fastFood);
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
                _sitDownRestaurant.SetDrinkItems(done);
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
                _sitDownRestaurant.SetNeedReservation(true);
            }

            else
            {
                _sitDownRestaurant.SetNeedReservation(false);
            }
        }

        _restaurants.Add(_sitDownRestaurant);
        _sitDownRestaurants.Add(_sitDownRestaurant);
        Console.Clear();
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

        foreach (Activity activity in _activities)
        {
            activity.Display();
        }
        Console.WriteLine($"\n(Press enter to continue)");
        Console.ReadLine();
        Console.Clear();
    }

    public void ListIndoorActivities()
    {
        Console.Clear();
        Console.WriteLine("Here are all the indoor activities! ");

        foreach (Activity activity in _indoorActivities)
        {
            activity.Display();
        }
        Console.WriteLine($"\n(Press enter to continue)");
        Console.ReadLine();
        Console.Clear();
    }

    public void ListOutdoorActivities()
    {
        Console.Clear();
        Console.WriteLine("Here are all the outdoor activities! ");

        foreach (Activity activity in _outdoorActivities)
        {
            activity.Display();
        }
        Console.WriteLine($"\n(Press enter to continue)");
        Console.ReadLine();
        Console.Clear();
    }

    public void ListAllRestaurants()
    {
        Console.Clear();
        Console.WriteLine("Here are all the restaurants! ");

        foreach (Restaurant restaurant in _restaurants)
        {
            restaurant.Display();
        }
        Console.WriteLine($"\n(Press enter to continue)");
        Console.ReadLine();
        Console.Clear();
    }
    public void ListFastFoodRestaurants()
    {
        Console.Clear();
        Console.WriteLine("Here are all the fast food restaurants! ");

        foreach (FastFoodRestaurant restaurant in _fastFoodRestaurants)
        {
            restaurant.Display();
        }
        Console.WriteLine($"\n(Press enter to continue)");
        Console.ReadLine();
        Console.Clear();
    }

    public void ListSitDownRestaurants()
    {
        Console.Clear();
        Console.WriteLine("Here are all the sit down restaurants! ");

        foreach (SitDownRestaurant restaurant in _sitDownRestaurants)
        {
            restaurant.Display();
        }
        Console.WriteLine($"\n(Press enter to continue)");
        Console.ReadLine();
        Console.Clear();
    }

    public Restaurant ChooseRandomRestaurant()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_restaurants.Count);
        Restaurant randomRestaurant = _restaurants[randomNumber];
        return randomRestaurant;
    }
    public FastFoodRestaurant ChooseRandomFastFood()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_fastFoodRestaurants.Count);
        FastFoodRestaurant randomRestaurant = _fastFoodRestaurants[randomNumber];
        return randomRestaurant;
    }
    public SitDownRestaurant ChooseRandomSitDown()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_fastFoodRestaurants.Count);
        SitDownRestaurant randomRestaurant = _sitDownRestaurants[randomNumber];
        return randomRestaurant;
    }
    public Activity ChooseRandomActivity()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_activities.Count);
        Activity randomActivity = _activities[randomNumber];
        return randomActivity;
    }
    public InsideActivity ChooseRandomIndoor()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_indoorActivities.Count);
        InsideActivity randomIndoor = _indoorActivities[randomNumber];
        return randomIndoor;
    }
    public OutsideActivity ChooseRandomOutdoor()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_outdoorActivities.Count);
        OutsideActivity randomOutdoor = _outdoorActivities[randomNumber];
        return randomOutdoor;
    }
}