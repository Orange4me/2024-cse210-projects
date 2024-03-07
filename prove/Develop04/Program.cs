using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;

        while (userSelection != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: \n1. Breathing Activity \n2. Refelcting Activity \n3. Listing Activity \n4. Quit");
            userSelection = int.Parse(Console.ReadLine());

                // List<string> DesignatedAct = new List<string> 
                // {
                //     $"{designatedAct} Activity"
                // }

            if (userSelection == 1)
            {
                Console.WriteLine("BreathingActivity");
                Breath BreathingActivity = new Breath();
                BreathingActivity.startMessage();
                BreathingActivity.animation();
                // BreathingActivity.durationActivity();
                BreathingActivity.endMessage();
                Console.ReadLine();
            }
            else if (userSelection == 2)
            {
                Console.WriteLine("ReflectingActivity");
            }
            else if (userSelection == 3)
            {
                Console.WriteLine("ListingActivity");
            }
        }

    }
}