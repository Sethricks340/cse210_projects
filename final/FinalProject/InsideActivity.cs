public class InsideActivity : Activity
{
    public InsideActivity(){}

    public override string Stringify()
    {
        //Inside|name
        //or
        //Inside|name|item1,item2,item3
        string stringify = "Inside";
        stringify += $"|{_name}|";
        if (_neededItems.Count != 0)
        {
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
        stringify += "|";

        return stringify;
    }

    public override void Display()
    {
        base.Display();
    }
}
