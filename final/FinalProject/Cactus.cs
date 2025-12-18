public class Cactus : Plant
{
    public Cactus(string name)
        : base(name, "Cactus", 30)
    {

    }
    public override string DisplayPlant()
    {
        return $"{_name} [{_plantType}] - Health: {_health}";
    }
    public override void Water()
    {
        double daysSinceWatered = (DateTime.Now - _lastwatered).TotalDays;
        if (daysSinceWatered < 11)
        {
            _health = "Dead";

        }
        else
        {
            _health = "Healthy";
        }
        _lastwatered = DateTime.Now;

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