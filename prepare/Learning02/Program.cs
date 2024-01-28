using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Del Taco", "Manager", 1706, 2020);
        Job job2 = new Job("Del Taco", "Cook", 2020, 2021);
    
        Resume r = new Resume("Brandon Alder");

        r.AddJob(job1);
        r.AddJob(job2);
        
        r.Display();
    }
}

// How do I instatiate a new calss?
//