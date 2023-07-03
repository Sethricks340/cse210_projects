public class FastFoodRestaurant : Restaurant
{
    public FastFoodRestaurant(){}
    public override string Stringify()
    {
        //FastFood|name
        //or
        //FastFood|name|food1,food2,food3
        //or
        //FastFood|name|drink1,drink2,drink3
        //or
        //FastFood|name|food1,food2,food3|drink1,drink2,drink3

        string stringify = "FastFood";
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
        return stringify;
    }
}