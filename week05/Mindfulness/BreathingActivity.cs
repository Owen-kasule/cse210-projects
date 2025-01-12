using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity helps you relax by guiding you through deep breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowSpinner(4);
            Console.WriteLine(" Breathe out...");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }
}
