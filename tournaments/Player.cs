public class Player
{
    private string _name;
    private string _position;
    private int _jersey;

    // public int ShoeSize;

    public Player(string name, int jersey)
    {
        _name = name;
        _jersey = jersey;

    }

    public Player(string name, int jersey, string position)
    {
        _name = name;
        _jersey = jersey;
        _position = position;

    }

    public void SetPosition(string position)
    {
        _position = position;
    }

    public string Display()
    {

        return $"{_name}: {_position} {_jersey}";
    }

}

