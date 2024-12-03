public class Video
{
    string _title;
    string _author;
    TimeSpan _length;
    List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = TimeSpan.FromSeconds(length);
        _comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void Display()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"By: {_author} Duration: {_length.Minutes}:{_length.Seconds}");
        Console.WriteLine($"{_comments.Count} Comments \n");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}