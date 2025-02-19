using System;

public class ProgressGoal : Goal
{
    private double _currentProgress;
    private double _goalTarget;

    public ProgressGoal(string name, string description, int points, double goalTarget)
        : base(name, description, points)
    {
        _currentProgress = 0;
        _goalTarget = goalTarget;
    }

    public override int RecordEvent()
    {
        _currentProgress++; // Increment progress

        Console.WriteLine($"📊 Progress updated for '{_name}': {_currentProgress}/{_goalTarget} completed.");

        if (IsComplete())
        {
            Console.WriteLine($"🎯 Goal '{_name}' fully completed! +{_points} points.");
            return _points * 2; // Example bonus for full completion
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _currentProgress >= _goalTarget;
    }

    public override string GetStringRepresentation()
    {
        return $"ProgressGoal:{_name},{_description},{_points},{_goalTarget},{_currentProgress}";
    }
}
