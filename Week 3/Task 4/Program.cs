using System;

namespace Task_4
{
    public class WeekDays
    {
        public void DisplayDay()
        {
            Console.Write("Enter a number (1-7) to get the corresponding day of the week: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            WeekDays weekDays = new WeekDays();
            weekDays.DisplayDay();
        }
    }
}