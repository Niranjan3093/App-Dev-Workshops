using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class FindingGroup
    {
        public void FindingCompatibleAge()
        {
            Console.WriteLine("Finding Group using If-else");

            Console.Write("Enter your age: ");
            int userAge;
            bool isValid = int.TryParse(Console.ReadLine(), out userAge);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                //return;
            }

            if (userAge > 0 && userAge < 13)
            {
                Console.WriteLine("You are a minor.");
                //return;
            }
            if (userAge >= 13 && userAge <= 19)
            {
                Console.WriteLine("You are a teenager.");
                //return;
            }
            if (userAge >= 20 && userAge <= 120)
            {
                Console.WriteLine("You are an adult.");
                //return;
            }

            Console.WriteLine("\nFinding Group using Switch Expression");

            switch (userAge)
            {
                case > 0 and < 13:
                    Console.WriteLine("You are a child.");
                    break;

                case >= 13 and < 20:
                    Console.WriteLine("You are a teenager.");
                    break;

                case >= 20 and < 120:
                    Console.WriteLine("You are an adult.");
                    break;

                default:
                    Console.WriteLine("Please enter a valid age.");
                    break;
            }

        }
    }
}
