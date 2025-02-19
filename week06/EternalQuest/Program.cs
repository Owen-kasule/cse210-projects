using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("🌟 Welcome to Eternal Quest! 🌟");
        Console.WriteLine("Track your goals, level up, and stay motivated.");
        
        GoalManager manager = new GoalManager();
        manager.Start();
        
        Console.WriteLine("Thank you for playing Eternal Quest! 🚀 Keep pushing towards your goals.");
    }
}
