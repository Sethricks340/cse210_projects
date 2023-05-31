public class Dvd : Loanable
{
    private string _title;
    public Dvd(string title)
    {
        _title = title;
    }   

    public override void Display()
    //override means that we know that it is in the parent class, but we 
    //are going to change it
    {
        base.Display();
        Console.WriteLine($"Title: {_title}");
    }
}