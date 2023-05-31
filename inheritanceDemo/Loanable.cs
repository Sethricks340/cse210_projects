public class Loanable
{
    private bool _isCheckedIn = true;

    public void CheckOut()
    {
        _isCheckedIn = false;
    }

    public void CheckIn()
    {
        _isCheckedIn = true;
    }

    public virtual void Display()
    //virtual just means that you can override it if you want
    {
        Console.WriteLine($"Available: {_isCheckedIn}");
    }


}