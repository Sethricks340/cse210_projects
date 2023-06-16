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

    public override string GetGoalDetails()
    {
        return $"SimpleGoal|{_goalName}|{_description}|{_pointValue}|{_completed}";
    }
}