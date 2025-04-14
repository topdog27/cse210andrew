
using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Andrew Hilton", "Learning Activity: Iheritance");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Andrew", "Multiplication", "1.1", "7-8");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Samulel", "English", "Essay: To Kill a Mocking Bird");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}