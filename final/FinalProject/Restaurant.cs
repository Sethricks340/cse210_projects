public abstract class Restaurant
{
    protected string _name = "";
    protected List<string> _foodItems = new List<string>();
    protected List<string> _drinkItems = new List<string>();
    // protected string _timeAvailable = "";

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


    
    // public void SetTimeAvailable()
    // {
    // }

    // public string GetTimeAvailable()
    // {
    //     return _timeAvailable;
    // }
}