using System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Brand = "Toyota";
        car.Speed = 150;
        car.Seats = 4;

        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        Motorcycle bike = new Motorcycle();
        bike.Brand = "Yamaha";
        bike.Speed = 125;
        bike.HasCarrier = true;

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();
    }
}
