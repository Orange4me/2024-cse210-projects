using System;

public class MathAssignment : Assignment
{
    private string _textbookSelection = "";
    private string _problems = "";



    public string GetTextbookSelection()
    {
        return _textbookSelection;
    }
    public void SetTextbookSelection(string textbookSelection)
    {
        _textbookSelection = textbookSelection;
    }

    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    

    public string GetHomeworkList()
    {
        return $"{GetSummary()} |--| Chapter: {_textbookSelection} |-| Problems: {_problems}";
    }
}