public class EternalGoals : Goal
{

    public EternalGoals(string name, string description, int points)
        : base(name, description, points)
    {
        _points = points;
    }
// 
    public override int GetPoints() // returns points
    {
        return _points;
    }

    public override int RecordEvent() // records events and returns points
    {
        return _points;
    }

    public override bool IsCompleted() // eternal goals are never completed
    {
        return false;
    }

    public override string DisplayGoal() // displays name and description
    {
        return $"{(IsCompleted() ? "[X]" : "[ ]")} {_name} ({_description})";
    }

    public override string GetStringRepresentation() // string representation for saving
{
    return $"{nameof(EternalGoals)}|{_name}|{_description}|{_points}";
}


}