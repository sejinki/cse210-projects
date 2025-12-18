public class Monstera : Plant
{
    private bool _hasMossPole;

    public Monstera(string name, bool _hasMossPole)
        : base(name, "Monstera", 7)
    {
        this._hasMossPole = _hasMossPole;
    }

    public override string DisplayPlant()
    {
        string mossPoleCheck = _hasMossPole ? "[X]" : "[ ]";
        return $"{_name} [{_plantType}] - Health: {_health} Moss Pole: {mossPoleCheck}";
    }

    public override void Water()
    {
        _lastwatered = DateTime.Now;
        _health = "Healthy";
        Console.WriteLine($"{_name} has been watered.");
    }

    public override void CurrentHealth()
    {
        double daysSinceWatered = (DateTime.Now - _lastwatered).TotalDays;

        if (daysSinceWatered >= _waterSchedule)
        {
            _health = "Dead";
        }
        else if (daysSinceWatered >= _waterSchedule - 1)
        {
            _health = "Wilting";
        }
        else if (daysSinceWatered >= _waterSchedule - 2)
        {
            _health = "Needs Water";
        }
        else
        {
            _health = "Healthy";
        }
    }
}