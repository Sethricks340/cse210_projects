public class SitDownRestaurant : Restaurant
{
    private bool _needReservation = false;
    public SitDownRestaurant(){}

    public void SetNeedResevation(bool reservation)
    {
        _needReservation = reservation;
    }

    public bool GetNeedResevation()
    {
        return _needReservation;
    }

    public override void Stringify()
    {}
}