public class fraction
{
    private int _top;
    private int _bottom;

    public fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double) _top / (double) _bottom;
        //I learned this from the internet and from the sample solution, but I have no idea why it doesn't work. Why can't I just do this:
        //                   return _top / _bottom;
        return  decimalValue;
    }
}