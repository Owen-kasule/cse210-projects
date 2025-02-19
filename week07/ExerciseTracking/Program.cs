using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Add sample activities
        activities.Add(new Running(new DateTime(2023, 11, 3), 30, 4.8)); // Running 4.8 km in 30 minutes
        activities.Add(new Cycling(new DateTime(2023, 11, 3), 45, 20.0)); // Cycling at 20 kph for 45 minutes
        activities.Add(new Swimming(new DateTime(2023, 11, 3), 25, 30)); // Swimming 30 laps in 25 minutes

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
