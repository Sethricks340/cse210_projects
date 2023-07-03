public abstract class Restaurant
{
    protected string _name = "";
    protected List<string> _foodItems = new List<string>();
    protected List<string> _drinkItems = new List<string>();

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetFoodItem(string foodItem)
    {
        _foodItems.Add(foodItem);
    }
    public List<string> GetFoodItems()
    {
        return _foodItems;
    }
    public void SetDrinkItems(string drinkItem)
    {
        _drinkItems.Add(drinkItem);
    }
    public List<string> GetDrinkItems()
    {
        return _drinkItems;
    }


    public abstract void Stringify();

    public virtual void Display()
    {
        Console.WriteLine($"\n{_name}!");
        
        if (_foodItems.Count != 0)
        {   
            Console.WriteLine($"Here are the food items that you've inputed:");
            foreach (string item in _foodItems)
            {
                // Console.WriteLine(_foodItems.IndexOf(item));
                // Console.WriteLine( _foodItems.Count - 1);
                Console.Write(_foodItems.IndexOf(item) != _foodItems.Count - 1 ? $"{item}, " : $"{item}\n");
            }
        }

        if (_drinkItems.Count != 0)
        {   
            Console.WriteLine($"Here are the drink items that you've inputed:");
            foreach (string item in _drinkItems)
            {
                // Console.WriteLine(_drinkItems.IndexOf(item));
                // Console.WriteLine( _drinkItems.Count - 1);
                Console.Write(_drinkItems.IndexOf(item) != _drinkItems.Count - 1 ? $"{item}, " : $"{item}\n");
            }
        }
    }

    public string ChooseRandomFood()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_foodItems.Count);
        string randomFood = _foodItems[randomNumber];
        return randomFood;
    }
    public string ChooseRandomDrink()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_drinkItems.Count);
        string randomDrink = _drinkItems[randomNumber];
        return randomDrink;
    }
}