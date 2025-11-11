using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Operator
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Addition: {a} + {b} = {result}");
        }

        public void Subtract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Subtraction: {a} - {b} = {result}");
        }

        public void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiplication: {a} * {b} = {result}");
        }

        public void Divide(int a, int b)
        {
            int result = a / b;
            Console.WriteLine($"Division: {a} / {b} = {result}");
        }

        public void OddEvenFinder (int number)
        {
            string result = (number % 2 == 0) ? "even Number" : "odd Number";
            Console.WriteLine($"{number} is an {result}");
        }
    }
}
