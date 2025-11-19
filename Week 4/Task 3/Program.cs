using System;
using Task_3;

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo pd = new ParameterDemo();

        int value = 20;
        pd.Increase(ref value);
        Console.WriteLine("Value after Increase: " + value);

        string myName;
        pd.GetFullName(out myName);
        Console.WriteLine("Full Name: " + myName);

        int result = pd.SumAll(10, 20, 30, 40);
        Console.WriteLine("Sum of all numbers: " + result);

        Console.ReadLine();
    }
}
