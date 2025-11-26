public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool isComplete();
    public string GetDetailsString()
    {
        /*
        EXAMPLE OUTPUT:
        You have 0 point.
            Menu Options:
            1.	Create New Goal
            2.	List Goals
            3.	Save. Goals
            4.	Load Goals
            5.	Record Event
            6.	Quit
            Select a choice from the menu: (cursor is here) 2
            The goals are:
            1.	[ ] Give a talk (Speak in Sacrament meeting when asked)
            2.	[ ] Study the scriptures (Study for at least 10 minutes)
            3.	[ ] Attend the temple (Attend and perform any ordinance) – Currently completed: 0/3
        */
        // This one is going to be virtual.
        return _shortName + " " + _description + " ";
    }
    public abstract string GetStringRepresentation();
}