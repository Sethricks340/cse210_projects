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

    public override string Stringify()
    {
        //SitDown|true
        //or
        //SitDown|name|food1,food2,food3|true
        //or
        //SitDown|name|drink1,drink2,drink3|true
        //or
        //SitDown|name|food1,food2,food3|drink1,drink2,drink3|true
        //or
        //SitDown|false
        //or
        //SitDown|name|food1,food2,food3|false
        //or
        //SitDown|name|drink1,drink2,drink3|false
        //or
        //SitDown|name|food1,food2,food3|drink1,drink2,drink3|false

        string stringify = "SitDown";
        stringify += $"|{_name}";
        if (_foodItems.Count != 0)
        {
            stringify += "|";
            foreach (string item in _foodItems)
            {
                if (_foodItems.IndexOf(item) != _foodItems.Count - 1)
                {
                    stringify += $"{item},";
                }

                else
                {
                    stringify += $"{item}";
                }
            }
        }

        if (_drinkItems.Count != 0)
        {
            stringify += "|";
            foreach (string item in _drinkItems)
            {
                if (_drinkItems.IndexOf(item) != _drinkItems.Count - 1)
                {
                    stringify += $"{item},";
                }

                else
                {
                    stringify += $"{item}";
                }
            }
        }
        stringify += $"|{_needReservation}";
        return stringify;
    }

    public override void Display()
    {
        base.Display();
        string reservation = (_needReservation) ? "yes" : "no";
        Console.WriteLine($"Need reservation: {reservation}");
    }
}