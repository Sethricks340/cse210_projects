public abstract class Activity
{   string _name = "";
    List<string> _neededItems = new List<string>();
    public Activity(){}

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void AddNeededItem(string neededItem)
    {
        _neededItems.Add(neededItem);
    }
    public List<string> GetNeededItems()
    {
        return _neededItems;
    }
    public abstract void Stringify();

}