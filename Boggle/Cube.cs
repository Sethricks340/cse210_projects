public class Cube
{
    public string? _cubeName = "";
    public int _xValue;
    public int _yValue;
    public Cube(int x, int y, string? cubeName){
        _xValue = x;
        _yValue = y;
        
        switch (cubeName)
        {
            case "1":
            _cubeName = "a";
            break;
            
            case "2":
            _cubeName = "b";
            break;

            case "3":
            _cubeName = "c";
            break;

            case "4":
            _cubeName = "d";
            break;

            case "5":
            _cubeName = "e";
            break;

            case "6":
            _cubeName = "f";
            break;

            case "7":
            _cubeName = "g";
            break;

            case "8":
            _cubeName = "h";
            break;

            case "9":
            _cubeName = "i";
            break;

            case "10":
            _cubeName = "j";
            break;

            case "11":
            _cubeName = "k";
            break;

            case "12":
            _cubeName = "l";
            break;

            case "13":
            _cubeName = "m";
            break;

            case "14":
            _cubeName = "n";
            break;

            case "15":
            _cubeName = "o";
            break;

            case "16":
            _cubeName = "p";
            break;
        }
    }
}