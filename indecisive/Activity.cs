public abstract class Activity
{   string _name = "";
    List<string> _neededItems = new List<string>();
    public Activity(){}

    public string GetName()
    {
        return _name;
    }
    public void SetName()
    {}
    public void AddNeededItems()
    {}
    public List<string> GetNeededItems()
    {
        return _neededItems;
    }
    public abstract void Stringify();

}