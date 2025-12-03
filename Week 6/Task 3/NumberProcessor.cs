
namespace Task_3;
public class NumberProcessor
{
    public void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (int n in numbers)
        {
            if (condition(n))
            {
                Console.WriteLine(n);
            }
        }
    }
}
