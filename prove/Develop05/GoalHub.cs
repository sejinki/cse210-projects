using System;
using System.Collections.Generic;
using System.IO;

public class GoalHub
{
    private List<Goal> _goals; // List to store goals
    private int _score; // Total score


    // method to get current score
    public int CurrentScore()
    {
        return _score;
    }


    // Constructor that runs when a new GoalHub is created
    public GoalHub()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // method to add a goal to the list
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    
// method to record an event for a specific goal
    public void RecordEvent(int index)
    {
        
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"Congratulations you have earned {points} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
// displays all goals
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available."); 
            return;
        }
        
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].DisplayGoal()}");
        }

    }


// displays total score
    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved!");
    }
// load goals from a file
    public void LoadGoals(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == nameof(OneTimeGoals))
            {
                bool isCompleted = bool.Parse(parts[4]);
                var goal = new OneTimeGoals(name, description, points);
                if (isCompleted) goal.RecordEvent();
                _goals.Add(goal);
            }
            else if (type == nameof(EternalGoals))
            {
                _goals.Add(new EternalGoals(name, description, points));
            }
            else if (type == nameof(ChecklistGoal))
            {
                int targetCount = int.Parse(parts[4]);
                int _currentCount = int.Parse(parts[5]);
                int _points = int.Parse(parts[6]);

                var goal = new ChecklistGoal(name, description, points, targetCount, points);
                _goals.Add(goal);
            }
            

        }

        Console.WriteLine("Goals are all here!");
    }

    
    

    
}