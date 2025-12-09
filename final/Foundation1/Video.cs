public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();
    public List<Video> _videos = new List<Video>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentsNumber()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"\n{_title} by {_author} ({_length} seconds)");
        Console.WriteLine($"Comments: ({GetCommentsNumber()})");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"> {comment.DisplayComment()}");
        }
    }
}