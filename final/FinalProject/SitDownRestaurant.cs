public class SitDownRestaurant : Restaurant
{
    private bool _needReservation = false;
    public SitDownRestaurant(){}

    public void SetNeedReservation(bool reservation)
    {
        _needReservation = reservation;
    }

    public bool GetNeedReservation()
    {
        return _needReservation;
    }

    public override void Stringify()
    {}

    public override void Display()
    {
        base.Display();
        string reservation = (_needReservation) ? "yes" : "no";
        Console.WriteLine($"Need reservation: {reservation}");
    }
}