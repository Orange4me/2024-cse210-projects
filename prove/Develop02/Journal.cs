using System;

public class Journal
{
    while (true)
    {
        // Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
        List<string> menuOptions = ["1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"];
        string selection = Console.ReadLine();
        int abjSelect = int.Parse(selection);

        for (int i = 0; i < menuOptions; i++)
        {
            Console.WriteLine($"{menuOptions[i]}")
        }

        Console.WriteLine("Enter number of choice you wish to select: ");

    }
}