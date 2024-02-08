using System;

class Program
{
    static void Main(string[] args)
    {
        // Account savings = new Account();
        // // savings._balance = 50;
        // savings.Deposit(100);  

        Fraction one = new Fraction();
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());

        Fraction whole = new Fraction(5);
        Console.WriteLine(whole.GetFractionString());
        Console.WriteLine(whole.GetDecimalValue());

        Fraction partial = new Fraction(4, 5);
        Console.WriteLine(partial.GetFractionString());
        Console.WriteLine(partial.GetDecimalValue());

        Fraction partial = new Fraction(3, 4);
        Console.WriteLine(partial.GetFractionString());
        Console.WriteLine(partial.GetDecimalValue());
    }
}