using System;

public class PropmptGenerator
{
    public List<string> _prompts = new List<string>()
    {
       "Who was the most interesting person I interacted with today?",
       "What was the best part of my day?",
       "How did I see the hand of the Lord in my life today?",
       "What was the strongest emotion I felt today?",
       "If I had one thing I could do over today, what would it be?"
    };
    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int i = randomPrompt.Next(_prompts.Count);

        return _prompts[i];
    }
}

// https://video.byui.edu/media/t/1_vmeovorz

// https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-9.0#examples
// The example I used for accessing the list was under: "The following example generates a random integer that uses an index to retrieve a string value from an array." I used a list. They also had ".Length" but our lesson says to use "Count" not "Length,"(because length, I thought, was Python?) so I used count. I don't know if this will work 😭

// Returning the index of the _prompts, or "return _prompts[i] came from our lesson about iterating through a List. This same area in our lesson also has examples of using Count with the instance of the list.