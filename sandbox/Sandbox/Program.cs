using System;

class Program
{
    static void Main(string[] args)
    {
        BaldEagle warthog = new BaldEagle("warthog");
        BaldEagle dragon = new BaldEagle("dragon");
        warthog.MakeSound(); 
        dragon.MakeSound();
    }
}