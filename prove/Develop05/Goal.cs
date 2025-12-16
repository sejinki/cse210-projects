using System.ComponentModel;

public abstract class Goal
{
    protected string _name;
    protected string _description;

    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetGoalName()
    {
        return _name;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public abstract int GetPoints(); // returns points
    public abstract int RecordEvent(); // records events and returns points
    public abstract bool IsCompleted(); // checks if goal is completed
    public abstract string DisplayGoal(); // displays goal information
    public abstract string GetStringRepresentation(); // string representation for saving



    

}