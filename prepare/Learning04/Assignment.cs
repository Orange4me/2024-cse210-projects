using System;

public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }



    public string GetSummary()
    {
        return $"Name: {_studentName} --> {_topic}";
    }

}