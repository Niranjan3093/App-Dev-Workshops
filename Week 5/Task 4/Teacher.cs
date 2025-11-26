using System;

public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    
    public virtual void SalaryInfo()
    {
        Console.WriteLine("Teacher salary is confidential.");
    }
}
