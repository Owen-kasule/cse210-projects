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

    public void AddProgress(double progress)
    {
        _currentProgress += progress;
        Console.WriteLine($"📊 Progress updated for '{_name}'. {Math.Min(_currentProgress, _goalTarget)}/{_goalTarget} completed.");

        if (_currentProgress >= _goalTarget)
        {
            Console.WriteLine($"🎯 Goal '{_name}' fully completed! +{_points} points.");
        }
    }

        public override int RecordEvent() // Match return type with base class
    {
        _progress++;
        return _points; // Return the points earned for progress
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
