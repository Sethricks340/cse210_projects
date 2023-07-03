public class OutsideActivity : Activity
{
    string _timeAvailable = "";

    public string GetTime()
    {
        return _timeAvailable;
    }

    public void SetTime(string timeAvailable)
    {
        _timeAvailable = timeAvailable;
    }

    public override string Stringify()
    {
        //Outside|name
        //or
        //Outside|name|item1,item2,item3
        //or
        //Outside|name|timeAvailable
        //or
        //Outside|name|item1,item2,item3|timeAvailable
        string stringify = "Outside";
        stringify += $"|{_name}";
        if (_neededItems.Count != 0)
        {
            stringify += "|";
            foreach (string item in _neededItems)
            {
                if (_neededItems.IndexOf(item) != _neededItems.Count -1)
                {
                    stringify += $"{item},";
                }

                else
                {
                    stringify += $"{item}";
                }
            }
        }

        if (_timeAvailable != "")
        {
            stringify += $"|{_timeAvailable}";
        }

        return stringify;
    }

    public override void Display()
    {
        base.Display();
        if (_timeAvailable != "")
        {
            Console.WriteLine($"Time this activity is available: {_timeAvailable}");
        }
    }
}