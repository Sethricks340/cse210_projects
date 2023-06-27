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
}