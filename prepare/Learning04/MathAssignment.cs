public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;
    public MathAssignment(string textBookSection, string problems, string name, string topic) : base(name, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"{base.GetSummary()}\n Textbook Section: {_textBookSection}\n Problems: {_problems}";
    }
}