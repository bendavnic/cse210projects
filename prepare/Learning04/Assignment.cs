public class Assignment
{
    string _studentName;
    string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}

public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection}, {_problems}";
    }
}

public class WritingAssignment : Assignment
{
    string _title;

    public WritingAssignment(string studentName, string topic,string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInfo()
    {
        return _title;
    }
}