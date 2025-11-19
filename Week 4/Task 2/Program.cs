using System;
using Task_2;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        calc.PrintWelcome();

        int sum = calc.Add(10, 20);
        int product1 = calc.Multiply(5, 4);
        int product2 = calc.Multiply(7);

        Console.WriteLine("Addition Result: " + sum);
        Console.WriteLine("Multiplication Result (5 * 4): " + product1);
        Console.WriteLine("Multiplication with default (7 * 1): " + product2);

        Console.ReadLine();
    }
}
