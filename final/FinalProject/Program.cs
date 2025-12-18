using System;

class Program
{
    static void Main(string[] args)
    {
        Greenhouse greenhouse = new Greenhouse();
        string choice = "";

        while (choice != "6")
        {
            // menu that the user sees to select from
            Console.Write("\nPlant Menu: \n1. Add Plant\n2. Display All Plants\n3. Display Plants Needing Care\n4. Display Dead Plants\n5. Water a Plant\n6. Leave the Greenhouse\nSelect a choice from the Plant Menu: ");
            choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                //menu for the user to select species of plants
                case "1":
                    Console.WriteLine("Select Plant Type:");
                    Console.Write("1. Epipremnum\n2. Begonia \n3. Succulent \n4. Monstera \n5. Cactus");
                    Console.WriteLine();
                    Console.Write("Which plant did you buy today?! (Choose 1-5): ");
                    string plantType = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Please enter the specific plant name: ");
                    string plantName = Console.ReadLine();

                    Plant newPlant = null;

                    // add plant based on user input

                    switch (plantType)
                    {
                        case "1":
                            newPlant = new Epipremnum(plantName);
                            break;
                        case "2":
                            newPlant = new Begonia(plantName);
                            break;
                        case "3":
                            newPlant = new Succulent(plantName);
                            break;
                        case "4":
                            Console.Write("Does the Monstera have a moss pole? (Y/N): ");
                            bool hasMossPole = Console.ReadLine().ToLower() == "y";
                            newPlant = new Monstera(plantName, hasMossPole);    
                            break;
                        case "5":
                            newPlant = new Cactus(plantName);
                            break;
                    }
                    // add the new plant to greenhouse
                    if (newPlant != null)
                    {
                        greenhouse.AddPlant(newPlant);
                        Console.WriteLine();
                        Console.WriteLine($"{plantName} has been added to your plant collection. ");
                    }
                    else
                    {
                        Console.WriteLine("Invalid plant type selected. Please select 1-5.");
                    }

                    break;
                case "2": // display all plants
                    greenhouse.DisplayAllPlants();
                    break;
                case "3": // display plants needing water / care
                    greenhouse.DisplayPlantsInNeed();
                    break;
                case "4": // displays dead plants
                    greenhouse.DisplayAllPlants();
                    break;
                case "5":
                    greenhouse.DisplayAllPlants(); //displays all plants by number
                    Console.Write("Enter the number of the plant you want to water: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        greenhouse.WaterPlant(index - 1);
                    }
                    else
                    {
                        Console.WriteLine("You can't water that!");
                    }

                    break;
                case "6": // quit
                    Console.WriteLine("You left the Greenhouse.");
                    break;

                default:
                    Console.WriteLine("Do right by the plants");
                    break;
                
            }
        }
    }
}