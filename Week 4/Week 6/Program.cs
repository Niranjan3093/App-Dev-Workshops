namespace Task6;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Marks:");
        int marks;
        int.TryParse(Console.ReadLine(), out marks);

        Console.Write("Enter Total:");
        int total;
        int.TryParse(Console.ReadLine(), out total);

        Console.WriteLine($"Marks: {marks}");
        Console.WriteLine($"Total: {total}");

        Console.WriteLine(marks / total);
        double percentage = (marks / total) * 100;

        Console.WriteLine($"The Percentage: {percentage}");

    }
}