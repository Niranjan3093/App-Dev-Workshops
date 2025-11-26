using System;

class Program
{
    static void Main(string[] args)
    {
        NepaliTeacher np = new NepaliTeacher();
        np.Name = "Mr. Sharma";
        np.Teaching();
        np.SalaryInfo();

        Console.WriteLine();

        EnglishTeacher eng = new EnglishTeacher();
        eng.Name = "Mrs. Thompson";
        eng.Teaching();
        eng.SalaryInfo();
    }
}
