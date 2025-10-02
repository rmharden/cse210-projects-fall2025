using System;

public class PromptGenerator
{
    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string RandomPromptGenerator()
    {
        Random _randomPrompt = new Random();
        int i = _randomPrompt.Next(_prompts.Count);
        return _prompts[i];
    }
}

// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-9.0
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count?view=net-9.0