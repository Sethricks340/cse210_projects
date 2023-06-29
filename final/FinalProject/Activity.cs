public abstract class Activity
{   protected string _name = "";
    protected List<string> _neededItems = new List<string>();
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

    public virtual void Display()
    {
        if (_neededItems.Count != 0)
        {
            Console.WriteLine($"\n{_name}!\nYou will need the following items:");
            
            foreach (string item in _neededItems)
            {
                // Console.WriteLine(_neededItems.IndexOf(item));
                // Console.WriteLine( _neededItems.Count - 1);
                Console.Write(_neededItems.IndexOf(item) != _neededItems.Count - 1 ? $"{item}, " : $"{item}\n");
            }
        }

        else
        {
            Console.WriteLine($"\n{_name}!");
        }
    }

}