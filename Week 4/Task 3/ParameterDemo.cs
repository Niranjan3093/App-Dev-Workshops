using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ParameterDemo
    {
        public void Increase(ref int number)
        {
            number = number + 10;
        }

        public void GetFullName(out string fullname)
        {
            fullname = "Niranjan Deuja";  // Assign your full name here
        }

        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
