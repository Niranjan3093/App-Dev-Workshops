namespace Task_2;

public delegate int Calculate(int a, int b);

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;
}
