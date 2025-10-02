using System;
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Step 8:
    public void Display()
    {
        Console.WriteLine($"\nName: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
        Console.WriteLine();
    }
}