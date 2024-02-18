public class Board
{


    List<int>  _x_values = new List<int>();
    List<int>  _y_values = new List<int>();
    List<List<int>> _units = new List<List<int>>();
    public Board()
    {
        for (int k = 1; k < 5; k++)
        {
            _x_values.Add(k);
            _y_values.Add(k);
        }

        for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    List<int> list1 = new List<int>() { i, j };   
                    _units.Add(list1);     
                } 
            }
    }


    public void DisplayValues()
    {
        Console.Write($"X Values of the Board: ");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{_x_values[i]} ");
        }

        Console.Write($"\nY Values of the Board: ");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{_y_values[i]} ");
        }

        Console.WriteLine($"\nUnits of the Board: ");
        foreach (var innerList in _units)
        {
            Console.Write($"(");
            foreach (var number in innerList)
            {
                Console.Write($"{number} ");
            }
            Console.Write($")");
            Console.Write("\n");
        }
    }
}