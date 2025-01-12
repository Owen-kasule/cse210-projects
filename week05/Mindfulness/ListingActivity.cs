using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "What are things you are grateful for?"
    };

    public ListingActivity() : base("Listing Activity", "This activity helps you reflect by listing positive things in your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        Console.WriteLine("List as many items as you can. Press Enter after each one.");
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        List<string> responses = new List<string>();
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count} items!");
        DisplayEndingMessage();
    }
}
