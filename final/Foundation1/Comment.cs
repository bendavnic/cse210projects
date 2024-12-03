public class Comment
{
    string _author;
    string _comment;
    public Comment(string author, string comment)
    {
        _author = author;
        _comment = comment;
    }
    public Comment(string author, string comment,Video video) : this(author, comment)
    {
        video.AddComment(this);
    }
    public void Display()
    {
        Console.WriteLine($"{_author} wrote: {_comment}");
    }
}