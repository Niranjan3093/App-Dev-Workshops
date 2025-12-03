namespace Task_2;

public delegate double DiscountStrategy(double price);

public class DiscountService
{
    public double FestivalDiscount(double price) => price * 0.20;
    public double SeasonalDiscount(double price) => price * 0.10;
    public double NoDiscount(double price) => price;

    public double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) => strategy(originalPrice);
}
