using System;

public class FiveSenses
{
    public List<string> _sensesPrompts = new List<string>()
    {
        "What did you see?",
        "What did you hear?",
        "What was the scent around you?",
        "What was the flavor you could taste?",
        "What did the feel like? What was the texture?"
    };
    public string GetRandomSense()
    {
        Random randomPrompt = new Random();
        int i = randomPrompt.Next(_sensesPrompts.Count);

        return _sensesPrompts[i];
    }
}