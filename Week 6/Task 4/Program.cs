using System.Collections.Generic;
using System.Linq;
namespace Task_4;

public class Program
{
    public static void Main()
    {
        // Square numbers
        List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
        var squared = nums.Select(n => n * n).ToList();
        Console.WriteLine("Squared: " + string.Join(", ", squared));

        // Books > 1000
        List<Book> books = new List<Book>
        {
            new Book {Title="Book A", Price=800},
            new Book {Title="Book B", Price=1500}
        };
        var premium = books.Where(b => b.Price > 1000);
        Console.WriteLine("Premium Books:");
        foreach (var b in premium) Console.WriteLine(b.Title);

        // Sort Students
        List<Student> students = new List<Student>
        {
            new Student {Name="Niranjan"},
            new Student {Name="Rezan"},
            new Student {Name="Deuja"}
        };
        var sorted = students.OrderBy(s => s.Name);
        Console.WriteLine("Sorted Students:");
        foreach (var s in sorted) Console.WriteLine(s.Name);
    }
}
