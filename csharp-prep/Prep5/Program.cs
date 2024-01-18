using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string GetName()
        {
            Console.WriteLine("What is your name? ")
            string name = Console.ReadLine();
            return name;
        }

        static int GetNumber()
        {
            Console.WriteLine("How old are you? ")
            string numb = Console.ReadLine();
            int number = int.Parse(numb);
            return number;
        }

        static int MultiplyNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static void IterateData(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}.")
        }
    }
}