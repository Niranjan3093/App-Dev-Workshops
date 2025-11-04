/*
 * Task 2: Constants  [ 5 Minutes ]
 * 
 * Create a class named Circle. 
 * Inside the class, declare a constant variable named PI and initialize it with the value 3.14.
 * In the Main() method of Program.cs,
 * Try to modify the value of PI of the Circle class and observe the compilation error and explain the error. 
 * Additionally, you can create methods to calculate area and perimeter of the circle.
 */


using System.Diagnostics;

public class Circle
{
    public const double PI = 3.14;
    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }
    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }

    public static void Main()
    {
        double radius = 5.0;
        double area = CalculateArea(radius);
        Circle circle = new Circle();
        double perimeter = circle.CalculatePerimeter(radius);
        Console.WriteLine($"For a circle with radius {radius}:");
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
        // Attempting to modify the constant PI will result in a compilation error
        // Uncommenting the following line will cause an error
        // PI = 3.14159; // Error: The left-hand side of an assignment must be a variable, property or indexer
    }
}