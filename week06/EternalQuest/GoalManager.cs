using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n===== Eternal Quest Menu =====");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalDetails();  // ✅ FIXED: Ensure this method exists
                    break;
                case "3":
                    CreateGoal();  // ✅ FIXED: Ensure this method exists
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    Console.WriteLine("Goodbye! Keep achieving your goals! 🚀");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"🌟 Current Score: {_score} points");
    }

    private void ListGoalDetails()  // ✅ FIXED: Added this missing method
    {
        Console.WriteLine("\n===== Your Goals =====");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals set yet. Create one now!");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void CreateGoal()  // ✅ FIXED: Added this missing method
    {
        Console.WriteLine("\nWhat type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points per completion: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing target: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }

        Console.WriteLine("✅ Goal created successfully!");
    }

    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Enter goal number to record progress: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _score += _goals[goalIndex].RecordEvent();
            Console.WriteLine("🎯 Goal recorded! Your updated score is: " + _score);
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter file = new StreamWriter("goals.txt"))
        {
            file.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("💾 Goals saved successfully!");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal")
            {
                int completed = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, completed));
            }
        }
        Console.WriteLine("📂 Goals loaded successfully!");
    }
}