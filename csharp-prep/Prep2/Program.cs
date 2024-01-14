using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string score = Console.ReadLine();
        float percent = float.Parse(score);
        
        string letter = "";

        if (percent >= 90)
        {
            letter = ("A");
        }
        else (percent >= 80)
        {
            letter = ("B");
        }
        else (percent >= 70)
        {
            letter = ("C");
        }
        else (percent >= 60)
        {
            letter = ("D");
        }
        else 
        {
            letter = ("F");
        }

        Console.WriteLine($"Grade: {letter}")


        if (percent >= 70)
        {
            Console.WriteLine("Congrats! You passed.");
        }
        else 
        {
            Console.WriteLine("Give it another shot.");
        }
    }
}