public class Job
{
    private string company;

    private string jobTitle;

    private int startYear;

    private int endYear;

    public Job (string companyname, string title, int start, int end)
    {
        company = companyname;
        jobTitle = title;
        startYear = start;
        endYear = end;
    }

    public void Display()
    {
        // Software Engineer (Microsoft) 2019-2022
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}
