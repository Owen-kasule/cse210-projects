using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What made you smile today?",
        "What are you grateful for?",
        "Describe a moment you felt proud.",
        "What was the highlight of your day?",
        "Who is someone you appreciate and why?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
