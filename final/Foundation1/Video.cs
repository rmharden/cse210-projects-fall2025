public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    private List<Video> _videos;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddCommentToList()
    {


    }
    public void DisplayAll()
    {
        foreach (Comment comment in _comments)
        {
            
        }
    }
    public int GetCommentsNumber()
    {
        return 0;
    }
}