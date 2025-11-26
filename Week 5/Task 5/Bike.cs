using System;

public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started with a self-start button.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped.");
    }
}
