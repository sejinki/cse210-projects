public abstract class Plant
{
    protected string _name;
    protected string _plantType;
    protected int _waterSchedule;
    protected DateTime _lastwatered;
    protected string _health;

// constructor initializes common traits of plants
    public Plant(string name, string plantType, int waterSchedule)
    {
        _name = name;
        _plantType = plantType;
        _waterSchedule = waterSchedule;
        _lastwatered = DateTime.Now;
        _health = "Healthy";
    }

    // waters the plant(s)
    public abstract void Water();
    public bool NeedsCare()
    {
        return _health == "Needs Water" || _health == "Wilting";
    }

    // returns true if plant is dead
    public bool IsDead()
    {
        return _health == "Dead";
    }
    //updates the plants health based off the watering schedule
    public abstract void CurrentHealth();
    
    // displays the plant
    public abstract string DisplayPlant();
}
   