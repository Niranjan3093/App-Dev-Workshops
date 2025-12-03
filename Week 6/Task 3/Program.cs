namespace Task_3;

public class Program
{
    public static void Main()
    {
        NumberProcessor p = new NumberProcessor();
        int[] nums = { 1, 2, 5, 12, 18, 3, 20 };

        Console.WriteLine("Even Numbers:");
        p.ProcessNumbers(nums, n => n % 2 == 0);

        Console.WriteLine("\nNumbers > 10:");
        p.ProcessNumbers(nums, n => n > 10);
    }
}
