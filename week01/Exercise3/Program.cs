using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomnumber = new Random();
        int number = randomnumber.Next(1, 101);
        Console.WriteLine("Guess the magic number!");
        Console.Write("Enter your guess: ");
        string guess = Console.ReadLine();
        int guess_int = int.Parse(guess);

        while (number != guess_int)
        {
            if (guess_int < number)
            {
                Console.WriteLine("Too Low!");
            }
            else
            {
                Console.WriteLine("Too high!");
            }
            Console.Write("Enter your guess: ");
            guess = Console.ReadLine();
            guess_int = int.Parse(guess);
        }
        Console.WriteLine("You guessed it!");
    }
}