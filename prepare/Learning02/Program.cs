using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._company = "Del Taco";
        job1._jobTitle = "Manager";
        job1._startYear = "1706";
        job1._endYear = "2020";
        job1.Display();
    }
}