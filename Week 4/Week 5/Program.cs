namespace Task5;

class Program
{
    public static void Main(string[] args)
    {

        Book obj = new Book("Math", "Ayush", 100);
        Book obj2 = obj with { title = "Science", price = 200 };

        Console.WriteLine(obj);
        Console.WriteLine(obj2);
        
        var (title, author, price) = obj;
        Console.WriteLine(title);
        Console.WriteLine(author);
        Console.WriteLine(price);

        try
        {
            Console.Write("Enter a day: ");
            string? day = (Console.ReadLine()).ToLower();

            List<string> weekday = ["sunday", "monday", "tuesday", "wednesday", "thursday"];
            List<string> weekend = ["friday", "saturday"];

            string output;

            if (day == null)
            {
                output = "NUll";
            }
            else if (weekday.Contains(day))
            {
                output = "Weekday";
            }
            else if (weekend.Contains(day))
            {
                output = "Weekend";
            }
            else
            {
                output = "Inapporate input";
            }
            Console.WriteLine(output);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}