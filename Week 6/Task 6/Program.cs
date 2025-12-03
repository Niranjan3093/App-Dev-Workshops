using System.Collections.Generic;
using System.Linq;
namespace Task_6;

public class Program
{
    public static void Main()
    {
        List<Tour> tours = new List<Tour>
        {
            new Tour{CustomerName="Niranjan", Destination="USA", Price=20000, DurationInDay=6, IsInternational=true},
            new Tour{CustomerName="Rezan", Destination="Korea", Price=8000, DurationInDay=3, IsInternational=false},
            new Tour{CustomerName="Deuja", Destination="Australia", Price=15000, DurationInDay=5, IsInternational=true}
        };

        var filtered = tours
            .Where(t => t.Price > 10000 && t.DurationInDay > 4);

        var projected = filtered.Select(t => new
        {
            t.CustomerName,
            t.Destination,
            Category = t.IsInternational ? "International" : "Domestic"
        });

        var sorted = projected
            .OrderBy(p => p.Category)     
            .ThenBy(p => p.CustomerName);

        Console.WriteLine("Tour Summary:");
        foreach (var t in sorted)
        {
            Console.WriteLine($"{t.CustomerName} → {t.Destination} → {t.Category}");
        }
    }
}
