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

    static void Main(string[] args)
    {
        job job2 = new job();
        job2._company = "Del Taco";
        job2._jobTitle = "Manager";
        job2._startYear = "1706";
        job2._endYear = "2020";
        job2.Display();
    }
    
    resume r = new resume();
    {
        r._name = "Brandon Alder"

        r._job.Add(job1);
        r._job.Add(job2);
        
        r.Display();
    }
}




// How do I instatiate a new calss?
//