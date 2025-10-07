// This is part of the "Shows Creativity" requirments: 

using System;

public class FiveSenses
{
    public List<string> _sensesPrompts = new List<string>()
    {
        "Sight:  What did you see?",
        "Sound:  What did you hear?",
        "Smell:  Was there a scent?",
        "Taste:  Could you taste anything? What was the flavor?",
        "Touch:  What did it feel like? Was there a texture?"
    };
    public string GetRandomSense()
    {
        Random randomPrompt = new Random();
        int i = randomPrompt.Next(_sensesPrompts.Count);

        return _sensesPrompts[i];
    }
}