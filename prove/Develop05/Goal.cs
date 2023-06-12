public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _pointValue;
    protected bool _completed;
    public Goal()
    {
    }

    public abstract void DisplayGoal();

    public void SetName(string goalName)
    {
        _goalName = goalName;
    }
    public string GetName()
    {
        return _goalName;
    }
    public void SetPoints(int points)
    {
        _pointValue = points;
    }
    public int GetPoints()
    {
        return _pointValue;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetComplete(bool completed)
    {
        _completed = completed;
    }
    public bool GetComplete()
    {
        return _completed;
    }
}