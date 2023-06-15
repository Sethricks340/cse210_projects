public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
    }

    public override void DisplayGoal()
    {
        if (_completed){
            Console.Write("[X] ");
        }
        else{
            Console.Write("[ ] ");
        }
        Console.WriteLine($"{_goalName} ({_description})");
    }

    

}