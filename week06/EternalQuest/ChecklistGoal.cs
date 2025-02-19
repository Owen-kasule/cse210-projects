public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        int earnedPoints = _points;

        if (_amountCompleted == _target)
        {
            earnedPoints += _bonus;
            Console.WriteLine($"🎉 Goal '{_name}' fully completed! Bonus +{_bonus} points.");
        }

        Console.WriteLine($"📌 Recorded progress for '{_name}'. +{earnedPoints} points.");
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" ✅ {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}
