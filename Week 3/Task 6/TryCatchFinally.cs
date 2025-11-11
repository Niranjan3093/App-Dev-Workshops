using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class TryCatchFinally
    {
        public void TypeCastingExample()
        {
                       try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                Console.WriteLine($"You entered the number: {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input format is incorrect. Please enter a valid integer.");
                Console.WriteLine($"Error details: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The number entered is too large or too small for an Int32.");
                Console.WriteLine($"Error details: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program Executed.");
            }
        }

        public void CheckPassword()
        {
            try
            {
                Console.Write("Enter your password: ");
                string pass = Console.ReadLine();

                if (pass.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
