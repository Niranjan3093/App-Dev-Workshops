using System;

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started with a key ignition.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped.");
    }
}
