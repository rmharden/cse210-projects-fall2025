public class Comment
{
    private string _name;
    private string _text;
    public Comment()
    {

    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}