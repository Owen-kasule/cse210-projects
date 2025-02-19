public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        return _amountCompleted >= _target ? _points + _bonus : _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{(_amountCompleted >= _target ? "[X]" : "[ ]")} {_name} ({_description}) -- Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}
