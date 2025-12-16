public class OneTimeGoals : Goal
{
    private bool _isCompleted;
   

    public OneTimeGoals(string name, string description, int points)
        : base(name, description, points)
    {
        _points = points;
        _isCompleted = false;
    }

    public override int GetPoints()
    {
        return _points;
    }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override bool IsCompleted()
    {
        return _isCompleted;
    }

    public override string DisplayGoal()
    {
        return $"{(IsCompleted() ? "[X]" : "[ ]")} {_name} ({_description})";
    }

    public override string GetStringRepresentation()
{
    return $"{nameof(OneTimeGoals)}|{_name}|{_description}|{_points}|{_isCompleted}";
}


}