using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel during this experience?",
        "What did you learn from this experience?",
        "How can this experience help you in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity helps you reflect on times when you showed strength.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Random rand = new Random();

        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}\n");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }
}
