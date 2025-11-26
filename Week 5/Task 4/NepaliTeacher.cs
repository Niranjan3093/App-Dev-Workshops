using System;

public class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine("Nepali Teacher teaches in Nepali language");
    }

    
    public sealed override void SalaryInfo()
    {
        Console.WriteLine("Nepali Teacher salary is confidential (sealed).");
    }
}
