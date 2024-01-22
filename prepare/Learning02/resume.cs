public class resume
{
    public string _name;


    // public List<job> jobs = new();   <---this works too
    public List<job> _jobs = new List<job>();

    public void Display;
    {
        foreach (job j in _jobs)
            {
                j.Display();
            }
    }
}