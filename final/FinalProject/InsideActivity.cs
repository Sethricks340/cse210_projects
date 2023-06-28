public class InsideActivity : Activity
{
    public InsideActivity(){}

    public override void Stringify()
    {}

    public override void Display()
    {
        if (_neededItems.Count != 0)
        {
            Console.WriteLine($"\n{_name}:\nYou will need the following items:");
            
            foreach (string item in _neededItems)
            {
                Console.Write(_neededItems.IndexOf(item) != _neededItems.Count - 1 ? $"{item}, " : $"{item}\n");
            }
        }

        else
        {
            Console.WriteLine($"\n{_name}");
        }
    }
}
