using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    // Abstract methods for distance, speed, and pace to be overridden by derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method for summary (calls overridden methods)
    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
