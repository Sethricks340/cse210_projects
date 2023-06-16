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

    public abstract string GetGoalDetails();

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
    public virtual int GetPoints()
    {
        return _pointValue;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual void SetComplete()
    {
        _completed = true;
    }

    public void SetCompleteVariable(bool complete)
    {
        _completed = complete;
    }
    public bool GetComplete()
    {
        return _completed;
    }
}