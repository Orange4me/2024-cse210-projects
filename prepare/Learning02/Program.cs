using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job("Del Taco", "Manager", "1706""-""2020");
        job job2 = new job("Del Taco", "Cook", "1708""-""2021");
    
        resume r = new resume("Brandon Alder");

        r.Addjob(job1);
        r.Addjob(job2);
        
        r.Display();
    }
}

// How do I instatiate a new calss?
//