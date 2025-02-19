using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
    }

    private void CheckLevelUp()
    {
        if (_score >= _level * 500)
        {
            _level++;
            Console.WriteLine($"🎖️ Level Up! You are now Level {_level}!");
        }
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Create Goal");
            Console.WriteLine("4. Show Score & Level");
            Console.WriteLine("5. Exit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ListGoalDetails();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    Console.WriteLine($"🎯 Score: {_score} | 🏆 Level: {_level}");
                    break;
                case "5":
                    return;
            }
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record progress:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        _goals[choice].RecordEvent();
        CheckLevelUp();
    }
}
