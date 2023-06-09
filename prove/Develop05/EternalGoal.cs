public class EternalGoal : Goal
{
    public EternalGoal()
    {
    }

    public override void DisplayGoal()
    { 
        Console.Write("[ ] ");
        Console.WriteLine($"{_goalName} ({_description})");
    }

    public override void SetComplete()
    {
        //Eternal goals can never really be completed.
        _completed = false;
    }

    public override string GetGoalDetails()
    {
        return $"EternalGoal|{_goalName}|{_description}|{_pointValue}";
    }
}