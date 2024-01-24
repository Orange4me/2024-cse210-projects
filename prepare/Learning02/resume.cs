public class resume
{
    private string name;


    // public List<job> jobs = new();   <---this works too
    public List<job> jobs = new List<job>();

    public resume(string yourname)
    {
        name = yourname;
    }
    public void Addjob (job j)
    {
        jobs.Add(j);
    }

    public void Display()
    {
        
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");
        foreach (job j in jobs)
            {
                j.Display();           
            }


    }
}