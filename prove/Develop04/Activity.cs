using System;
using System.Timers;

public class Activity
{
    protected string _namedAct;
    protected string _description;
    protected int _duration;


    // public string ActStructure()
    // {
        
    // }
    
    public void startMessage()
    {
        Console.Clear();
        Console.WriteLine($"Thank you for joining the {_namedAct} Activity \n{_description}" );
    }

    public int durationActivity()
    {
        _duration = 
        


    }
    
    public int animation()
    {
        Console.Clear();
        int frame = 0;  
        while(frame<_duration)
        {
            
        }

    }

    public void endMessage()
    {
        
        Console.WriteLine($"Congradulations! You finished the {_namedAct}. Join again another time!");
    }


    
}