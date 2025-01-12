public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity helps you relax through paced breathing. Clear your mind and focus on your breathing.")
    { }

    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 8; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
    }
}
