public class BadHabitGoal : Goal
{
    public BadHabitGoal(string name, string description, int penalty)
        : base(name, description, -penalty) { }

    public override int RecordEvent() // Now returns int
    {
        _points -= 10;
        return -10; // Return the points lost
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
