public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }














//     public class MathAssignment: Assignment
//     {
//         private string _textbookSection;
//         private string _problems;

//         public void GetHomeworkList()
//         {
//         }
//     }

//     public class WritingAssignment: Assignment
//     {
//         private string _title;

//         public void GetWritingInformation()
//         {
//         }
//     }

}