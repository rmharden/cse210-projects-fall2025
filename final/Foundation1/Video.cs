public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public List<Video> _videos = new List<Video>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void AddCommentToList(Comment comment)
    {
        _comments.Add(comment);

    }
    public List<Comment> DisplayAll()
    {
        return _comments;
    }
    public int GetCommentsNumber()
    {
        return _comments.Count;
    }
}