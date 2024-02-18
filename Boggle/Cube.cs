public class Cube
{
    public string? _cubeName = "";
    public int _xValue;
    public int _yValue;
    public Cube(int x, int y, string? cubeName){
        _xValue = x;
        _yValue = y;
        _cubeName = cubeName;
    }

    public void EditCubeName(string cubeName)
    {
        _cubeName = cubeName;
    }
}