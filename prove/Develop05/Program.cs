using System;

class Program
{
    static void Main(string[] args)
    {
        // create a goalhub instance

        GoalHub goalHub = new GoalHub();

        // stires user input for menu choice
        string choice = "";

        // Main loop that keeps running until user decies to quit

        while (choice != "6")
        {
            Console.WriteLine();
            Console.WriteLine($"You have {goalHub.CurrentScore()} points.");
            Console.WriteLine();
            Console.Write("\n Menu Options: \n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n Select a choice from the Menu: ");
            choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)

            {
                // create a new goal
                case "1":
                    Console.Write("\nThe types of Goals are: \n1. One-Time Goal\n2. Eternal Goal\n3. Checklist Goal\n Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    if (goalType == "1")
                    {
                        goalHub.AddGoal(new OneTimeGoals(name, description, points));
                    }
                    else if (goalType == "2")
                    {
                        goalHub.AddGoal(new EternalGoals(name, description, points));

                    }
                    else if (goalType == "3")
                    {
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int targetCount = int.Parse(Console.ReadLine());

                        Console.Write("What is the amount of bonus points for accomplishing it that many times? ");
                        int bonusPoints = int.Parse(Console.ReadLine());

                        goalHub.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));

                    }
                    else
                    {
                        Console.WriteLine("Invalid Goal Type");
                    }
                    break;
                // display all goals
                case "2":
                    goalHub.DisplayGoals();
                    break;
                // save goals
                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    string saveFileName = Console.ReadLine();
                    goalHub.SaveGoals(saveFileName);
                    break;
                // load goals
                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    string loadFilename = Console.ReadLine();
                    goalHub.LoadGoals(loadFilename);
                    break;
                // 
                case "5":
                    goalHub.DisplayGoals();
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine());
                    goalHub.RecordEvent(goalIndex - 1);
                    break;

                // 
                case "6":
                    break;
                // 
                case "7":
                    Console.WriteLine("The end.");
                    break;
                // invalid input
                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}