using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.")

        List<int> numbers = new List<int>();
        
        input = 1;

        while (input !=0)
        {
            Console.WriteLine("Enter number: ")
            string ninput = Console.Read();
            int input = int.Parse(ninput);

            if (input !=0)
            {
                numbers.Add(input);
            }
        }
        foreach (float number in numbers)
        {
            sum += number;
        }
        
        int avg = input.Average();
        
        foreach (number in numbers)
        {
            if (max < number)
            {
                max = number;
            }
        }
        Console.WriteLine($"Sum of numbers: {total}")
        Console.WriteLine($"Avg of numbers: {avg}")
        Console.WriteLine($"Biggest of numbers: {max}")

        
    }
}