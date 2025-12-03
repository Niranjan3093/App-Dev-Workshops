namespace Task_2;
public class Program
{
    public static void Main()
    {
        //Calculator class
        Calculator calc = new Calculator();

        Calculate del1 = calc.Add;
        Calculate del2 = calc.Subtract;

        Console.WriteLine("Add: " + del1(10, 5));
        Console.WriteLine("Subtract: " + del2(10, 5));


        //DiscountService class
        DiscountService service = new DiscountService();

        double price = 1000;

        Console.WriteLine("Festival Discount: " + service.CalculateFinalPrice(price, service.FestivalDiscount));

        Console.WriteLine("Seasonal Discount: " + service.CalculateFinalPrice(price, service.SeasonalDiscount));

        Console.WriteLine("No Discount: " + service.CalculateFinalPrice(price, service.NoDiscount));

        Console.WriteLine("30% Lambda Discount: " + service.CalculateFinalPrice(price, p => p * 0.70));
    }
}
