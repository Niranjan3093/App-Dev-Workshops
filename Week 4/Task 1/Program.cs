/*
 * Inside a new class named Student, perform following tasks:
Create 3 instance fields for storing any of the student details.
Create 1 static field 
In Program.cs class, create two objects of Student.
Assign different values for instance fields for both object.
Display the field values of both objects and print the static field.
 * 
 */
namespace Task1;

class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student("Niranjan", 20, 3093);
        Student s2 = new Student("Rezan", 20, 3099);

        Console.WriteLine($"Name : {s1.name} Age : {s1.age} Id : {s1.id}");
        Console.WriteLine($"Name : {s2.name} Age : {s2.age} Id : {s2.id}");
    }
}
