using System;

public class Greenhouse
{
    private List<Plant> _plants;

    public Greenhouse()
    {
        
        _plants = new List<Plant>();

    }

    public void AddPlant(Plant plant)
    {
        _plants.Add(plant);
    }

    public void DisplayAllPlants()
    {   //creates a list of living plants
        List<Plant> livingPlants = new List<Plant>();
            foreach (Plant plant in _plants) // filter dead plants
            {
                if (!plant.IsDead())  // Only add plants that are not dead
                {
                    livingPlants.Add(plant);
                }
            }
        //checks all living plants
        if (livingPlants.Count == 0)
        {
            Console.WriteLine("No plants to display.");
            return;
        }
        // displays living plants
        for (int i = 0; i < livingPlants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {livingPlants[i].DisplayPlant()}");

        }


    }
    //displays plants that need attention/ water
    public void DisplayPlantsInNeed()
    {
        bool anyNeedsCare = false;
        foreach (Plant plant in _plants)
        {
            if (plant.NeedsCare())
            {
                Console.WriteLine(plant.DisplayPlant());
                anyNeedsCare = true;
            }
        }
        if (!anyNeedsCare)
            {
                Console.WriteLine("Your plants are healthy!");
            }
    }

    public void DisplayDeadPlants()
    {
        bool anyDead = false;
        foreach (Plant plant in _plants)
        {
            plant.NeedsCare();

            if (plant.IsDead())
            {
                Console.WriteLine(plant.DisplayPlant());
                anyDead = true;

            }
        }

        if (!anyDead)
        {
            Console.WriteLine("No dead plants.");
        }
    }

    public void WaterPlant(int index)
    {
        if (index < 0 || index >= _plants.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        _plants[index].Water();
        Console.WriteLine("Plant(s) watered. Good Job!! ");
    }
    

}