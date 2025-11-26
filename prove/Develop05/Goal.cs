/*

1. Use inheritance and have a separate class for each kind of activity with a base class to contain any shared attributes or behaviors.
2. Use polymorphism by having dervived classes override base class methods where appropriate.
3. Follow the principles of encapsulation and abstraction by having private member variables and putting reltated items in the same class.

*/
public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailString()
    {
        return "";
    }
    public abstract string GetStringRepresentation();
}