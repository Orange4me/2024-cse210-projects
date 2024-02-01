using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter number of choice you wish to select: ");
            // Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            List<string> menuOptions = new List<string> ["1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"];
            string selection = Console.ReadLine();
            int abjSelect = int.Parse(selection);

            if (selection = 1)
                {

                }
            else (selection = 2)
            {
                
            }
            else (selection = 3)
            {
                
            }
            else (selection = 4)
            {
                
            }
            else (selection = 5)
            {
                break;
            } 
        }
    }
}