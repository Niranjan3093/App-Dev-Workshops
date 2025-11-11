using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Loops
    {
        public void calculateSum()
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum from 1 to {num} is: {sum}");
        } 

        public void printNumbers()
        {
            int i = 1;
            while (i <= 20)
            {
                if (i == 15)
                {
                    break;
                }
                if (i % 4 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }

        public void sumOfElemInArray()
        {
            int[] numbers = { 12, 45, 23, 67, 34, 89, 90, 11, 10, 5 };
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of the elements in the array is: {sum}");
        }
    }
}
