using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost recently?",
        "Who are your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity encourages you to reflect on good things in your life by listing them.")
    { }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(5);

        List<string> userItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.WriteLine("Start listing items:");
        while (DateTime.Now < endTime)
        {
            userItems.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {userItems.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}
