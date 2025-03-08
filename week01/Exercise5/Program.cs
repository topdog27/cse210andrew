using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcom to the Program!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your favorite number: ");
    
        string number = Console.ReadLine();
        int number_int = int.Parse(number);
        float square = number_int * number_int;
        Console.WriteLine($"{name}, the square of your favorite number is {square}");
    }
}