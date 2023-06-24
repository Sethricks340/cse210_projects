public abstract class Activity
{   string _name;
    List<string> _neededItems;
    public Activity(){}

    public string GetName()
    {}
    public void SetName()
    {}
    public void AddNeededItems()
    {}
    public List<string> GetNeededItems()
    {}
    public abstract void Stringify();

}