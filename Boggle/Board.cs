public class Board
{


    List<int>  _x_values = new List<int>();
    List<int>  _y_values = new List<int>();
    List<List<int>> _units = new List<List<int>>();
    List<Cube> _cubes = new List<Cube>();
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
        for (int i = 1; i < _units.Count+1; i++)
        {
            Cube _ = new Cube(_units[i-1][0], _units[i-1][1], i.ToString());
            _cubes.Add(_);
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

        Console.WriteLine($"\nCube names of the Board: ");
            for (int i = 0; i < _cubes.Count; i++)
            {
                Console.WriteLine($"{_cubes[i]._cubeName}");
            }
    }

    public void EnterLetters()
    {
        Console.ReadLine();
    }

    public void DisplayBoard()
    {
        Console.Write($"-----------------\n");
        Console.Write($"| {_cubes[0]._cubeName} | {_cubes[1]._cubeName} | {_cubes[2]._cubeName} | {_cubes[3]._cubeName} |\n");
        Console.Write($"-----------------\n");
        Console.Write($"| {_cubes[4]._cubeName} | {_cubes[5]._cubeName} | {_cubes[6]._cubeName} | {_cubes[7]._cubeName} |\n");
        Console.Write($"-----------------\n");
        Console.Write($"| {_cubes[8]._cubeName} | {_cubes[9]._cubeName} | {_cubes[10]._cubeName} | {_cubes[11]._cubeName} |\n");
        Console.Write($"-----------------\n");
        Console.Write($"| {_cubes[12]._cubeName} | {_cubes[13]._cubeName} | {_cubes[14]._cubeName} | {_cubes[15]._cubeName} |\n");
        Console.Write($"-----------------");
    }

    public void EditBoard()
    {
        Console.Clear();
        DisplayBoard();
        for (int i = 1; i < _units.Count + 1; i++)
        {
            Console.Clear();
            DisplayBoard();
            string? response = " ";
            Console.WriteLine($"\nPlease enter letter for cube #{i}: ");
            response = Console.ReadLine();
            _cubes[i-1]._cubeName = response.ToUpper();
        }
    }
}