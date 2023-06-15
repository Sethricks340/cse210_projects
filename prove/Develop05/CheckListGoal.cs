public class CheckListGoal : Goal
{
    private int _bonus = 0;
    private int _timesToComplete = 0;
    private int _timesCompleted = 0;

    public CheckListGoal()
    {
    }

    public override void DisplayGoal()
    {
        Console.Write($"[{_timesCompleted}/{_timesToComplete}] ");
        Console.WriteLine($"{_goalName} ({_description})");
    }

    public void SetBonus(int bonus)
    {  
        _bonus = bonus;
    }

    public override int GetPoints()
    {
        if (_timesCompleted != _timesToComplete)
        {
            return base.GetPoints();
        }

        else 
        {
            return base.GetPoints() + _bonus;
        }
    }

    public void SetTimesToComplete(int timesToComplete)
    {
        _timesToComplete = timesToComplete;
    }

    public override void SetComplete()
    {
        if (_timesCompleted < _timesToComplete)
        {
            _timesCompleted += 1;

            if (_timesCompleted == _timesToComplete)
            {
                _completed = true;
                Console.Write($"You earned a bonus! \n(Press enter to continue) ");
                Console.ReadLine();
            } 
        }

        else
        {
             _completed = true;
        }
    }

}