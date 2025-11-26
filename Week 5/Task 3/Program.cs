using System;

class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer();

        p.Print("Hello World");      
        p.Print(100);                
        p.Print("Repeated Message", 3); 
    }
}
