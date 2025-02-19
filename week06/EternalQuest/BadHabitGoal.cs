public class BadHabitGoal : Goal
{
    public BadHabitGoal(string name, string description, int penalty)
        : base(name, description, -penalty) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"⚠️ Bad habit triggered: '{_name}'. Lost {_points} points.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"BadHabitGoal:{_name},{_description},{_points}";
    }
}
