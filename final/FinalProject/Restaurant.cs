public abstract class Restaurant
{
    protected string _name = "";
    protected List<string> _foodItems = new List<string>();
    protected List<string> _drinkItems = new List<string>();
    protected string _timeAvailable = "";

    public void SetName()
    {
    }
    public string GetName()
    {
        return _name;
    }
    public void SetFoodItems()
    {
    }
    public List<string> GetFoodItems()
    {
        return _foodItems;
    }
    public void SetDrinkItems()
    {
    }
    public List<string> GetDrinkItems()
    {
        return _drinkItems;
    }
    public void SetTimeAvailable()
    {
    }
    public string GetTimeAvailable()
    {
        return _timeAvailable;
    }
    public abstract void Stringify();
}