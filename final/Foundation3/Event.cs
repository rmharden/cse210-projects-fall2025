/*
This is going to be the base class.
*/

public abstract class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    public Event()
    {

    }
    public string StandardDetails()
    {
        //Lists
        return _eventTitle + "\n" + _description + "\n" + _date + "\n" + _time + "\n" + _address;
    }
    public void FullDetails()
    {
        //Lists
        Console.WriteLine(StandardDetails());
        Console.WriteLine($"");
    }
    
}