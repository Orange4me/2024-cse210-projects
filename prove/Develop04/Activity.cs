using System;
using System.Timers;

public class Activity
{
    protected string _namedAct;
    protected string _description;
    protected int _duration;
    protected char[] _animation =
    {
        '-',
        '\\',
        '|',
        '/'
    };


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
        // _duration = 
        return 5;
    }
    
    public void animation()
    {
        for (int a = 0; a < 5; a++)
        {
           Console.Write(_animation[a % _animation.Length]); //study up on modulo
           Thread.Sleep(1000);
           Console.Write1("\b");
        }


        // int timeFrame = 0;  
        // while(frame<_duration)
        // {
            
        // }

    }

    public void endMessage()
    {
        
        Console.WriteLine($"Congradulations! You finished the {_namedAct}. Join again another time!");
    }


    
}