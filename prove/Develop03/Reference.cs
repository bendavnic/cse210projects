public class Reference
{
    private string _book;
    private string _chapter;
    private string _startverse;
    private string _endverse;


    public Reference(string book, string chapter, string startverse, string endverse = null)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }
    public void SetEnd(string end)
    {
        _endverse = end;
    }
    public string Out()
    {
        if (_endverse == null)
        {
            return $"{_book} {_chapter}:{_startverse}";
        }
        else
        {
            return$"{_book} {_chapter}:{_startverse}-{_endverse}";
        }
    }

}