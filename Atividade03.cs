using System;

class Program
{
    static void Main()
    {
        int dias = int.Parse(Console.ReadLine());
        
        int anos = dias / 365;  
        dias %= 365;  
        
        int meses = dias / 30; 
        
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}