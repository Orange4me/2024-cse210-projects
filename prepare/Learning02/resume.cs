using System.Security.Cryptography.X509Certificates;

public class Resume
{
    private string name;


    // public List<job> jobs = new();   <---this works too
    public List<Job> jobs = new List<Job>();

    public Resume(string yourname)
    {
        name = yourname;
    }
    public void AddJob (Job j)
    {
        jobs.Add(j);
    }

    public void Display()
    {
        
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");
        foreach (Job j in jobs)
            {
                j.Display();           
            }
    
    }
    
}