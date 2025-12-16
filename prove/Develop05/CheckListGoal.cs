public class ChecklistGoal : Goal
{
    private int _pointsPerEvent;
    private int _targetCount;
    private int _currentCount;

    int _bonusPoints;

    public ChecklistGoal(string name, string description, int pointsPerEvent, int targetCount, int bonusPoints)
        : base(name, description, pointsPerEvent)
    {
        _pointsPerEvent = pointsPerEvent;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
        

    }

    public override int GetPoints()
    {
        return _pointsPerEvent;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                return _pointsPerEvent + _bonusPoints;
            }
            return _pointsPerEvent;
        }
        return 0;
    }

    public override bool IsCompleted()
    {
        return _currentCount >= _targetCount;
    }

    public override string DisplayGoal()
    {
        return $"{(IsCompleted() ? "[X]" : "[ ]")}{_name} ({_description}) -- Currently completed: {_currentCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
{
    return $"{nameof(ChecklistGoal)}|{_name}|{_description}|{_pointsPerEvent}|{_targetCount}|{_currentCount}|{_bonusPoints}";
}
}