using System;

namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Operator op = new Operator();
            op.Add(10, 5);
            op.Subtract(10, 5);
            op.Multiply(10, 5);
            op.Divide(10, 5);
            op.OddEvenFinder(10);
            op.OddEvenFinder(7);


            Console.ReadLine();
        }
    }
}