public class job
{
    public string _company;

    public string _jobTitle;

    public int _startYear;

    public int _endYear;

    public void Display(){
        // Software Engineer (Microsoft) 2019-2022
        Console.WriteLine($"{"_jobTitle} ({_company}) {_startYear}-{_endYear});
    }
}