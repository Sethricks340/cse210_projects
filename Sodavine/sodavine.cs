public class Sodavine
{
     List<string> _sodas = new List<string>();

    public Sodavine()
    {
        _sodas.Add("Southern gentlemen");
        _sodas.Add("nailed it");
        _sodas.Add("run around sue");
        _sodas.Add("freight train");
        _sodas.Add("oh what a night");
        _sodas.Add("smooth presley");
        _sodas.Add("uptowngirl");
        _sodas.Add("I love lucy");
        _sodas.Add("Huckleberry");
        _sodas.Add("The Izzy classic!!");
        _sodas.Add("Louie Louie");
        _sodas.Add("Locomotion");
    }


    public string GetRandomPrompt()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_sodas.Count);
        string randomPrompt = _sodas[randomNumber];
        return randomPrompt;
    }



}