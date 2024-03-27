using System;

public class ControlSys
{
    string control = 100000000

    while (control != 5)
    {
        Console.WriteLine("Please select from the following options: \n1. All lights on \n2. All lights off \n3. A/C and Heater \n4. Bath \n5. Quit");
        control = Console.ReadLine("");
        if (control = 1)
        {
            Light allLights = new Light("AllOn");
            Light.TurnOn();

        }
        else if (control = 2)
        {
            Console.WriteLine("AllOff")
        }
        else if (control = 3)
        {
            Console.WriteLine("A/C and Heater")
        }
        else if (control = 4)
        {
            Console.WriteLine("Bath")
        }
    }
}