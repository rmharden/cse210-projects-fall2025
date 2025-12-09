public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    private List<Video> _videos = new List<Video>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
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