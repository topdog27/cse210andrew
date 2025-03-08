using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int grade_int = int.Parse(grade);
        if (grade_int >= 90)
        {
            Console.WriteLine("You got an A");
        }
        else if (grade_int >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (grade_int >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (grade_int >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You got an F");
        }
    }
}