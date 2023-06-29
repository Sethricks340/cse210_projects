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

    public override void Stringify()
    {}

    public override void Display()
    {
        base.Display();
        if (_timeAvailable != "")
        {
            Console.WriteLine($"Time this activity is available: {_timeAvailable}");
        }
    }
}