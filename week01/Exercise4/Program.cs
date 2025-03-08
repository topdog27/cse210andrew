using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter 0 to quit");
        int number_int = 1;

        while (number_int != 0)
        {
            Console.Write("Enter A Number; ");
            string number = Console.ReadLine();
            number_int = int.Parse(number);
            if (number_int != 0)
            {
                numbers.Add(number_int);
            }

        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        float average = ((float)sum) / numbers.Count;
    
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The max is {max}");
    
    }
}