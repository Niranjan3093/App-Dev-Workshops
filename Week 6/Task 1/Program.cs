namespace Task_1;

public class Program
{
    public static void Main()
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Length = 10;
        rectangle.Breadth = 5;
        Console.WriteLine("Rectangle Details:");
        Console.WriteLine(rectangle.showDetails());
    }
}