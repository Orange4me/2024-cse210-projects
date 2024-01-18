using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine("Guess that magic number from 1-100!");
        int guess = 0;



        while (guess != number)
        {

        Console.WriteLine("Guess again!"); 

        if (guess > number)
        {
            Console.WriteLine("Hint: lower")
        }
        else (guess < number)
        {
            Console.WriteLine("Hint: higher")
        }

        string reguess = Console.ReadLine();
        int guess = int.Parse(reguess);

        }

        Console.WriteLine("You got it!!! Play again?")

    }
}