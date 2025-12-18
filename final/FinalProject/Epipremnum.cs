using System;

public class Epipremnum : Plant
{
    public Epipremnum(string name)
        : base(name, "Epipremnum", 8)
    {

    }
    public override string DisplayPlant() //displays plant
    {
        return $"{_name} [{_plantType}] - Health: {_health}";
    }
    public override void Water() // waters plant
    {
        _lastwatered = DateTime.Now;
        _health = "Healthy";
        Console.WriteLine($"{_name} has been watered.");
    }

    public override void CurrentHealth() //assess current status of plant with their health and returns a string of the "health"
    {
        double daysSinceWatered = (DateTime.Now - _lastwatered).TotalDays;

        if (daysSinceWatered >= _waterSchedule)
        {
            _health = "Dead";
        }
        else if (daysSinceWatered >= _waterSchedule - 2)
        {
            _health = "Wilting";
        }
        else if (daysSinceWatered >= _waterSchedule - 6)
        {
            _health = "Needs Water";
        }
        else
        {
            _health = "Healthy";
        }
    }
}