using System.Linq;
using System.Collections.Generic;

namespace Task_5;

public class Program
{
    public static void Main()
    {
        // Aggregation
        List<CashierSales> sales = new List<CashierSales>
        {
            new CashierSales{CashierName="A", Sales=5000},
            new CashierSales{CashierName="B", Sales=8000},
            new CashierSales{CashierName="C", Sales=3000}
        };

        Console.WriteLine("Cashier Count: " + sales.Count());
        Console.WriteLine("Total Sales: " + sales.Sum(s => s.Sales));
        Console.WriteLine("Highest: " + sales.Max(s => s.Sales));
        Console.WriteLine("Lowest: " + sales.Min(s => s.Sales));
        Console.WriteLine("Average: " + sales.Average(s => s.Sales));

        // Quantifiers
        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant{Name="A", Age=17},
            new Applicant{Name="B", Age=20}
        };

        Console.WriteLine("Any under 18: " + applicants.Any(a => a.Age < 18));
        Console.WriteLine("All above 16: " + applicants.All(a => a.Age > 16));

        // Songs
        List<Song> songs = new List<Song>
        {
            new Song{Title="X", DurationSec=120},
            new Song{Title="Y", DurationSec=300},
            new Song{Title="Z", DurationSec=700}
        };

        Console.WriteLine("First song: " + songs.First().Title);
        Console.WriteLine("Last song: " + songs.Last().Title);
        Console.WriteLine("First song > 4 min: " +
            songs.First(s => s.DurationSec > 240).Title);

        var safe = songs.FirstOrDefault(s => s.DurationSec > 600);
        Console.WriteLine("First >10 min (safe): " + (safe?.Title ?? "None"));
    }
}
