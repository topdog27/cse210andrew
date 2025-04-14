using System;
using System.Threading;

namespace MindfulnessActivities
{
    public class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        protected void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} activity.");
            Console.WriteLine(_description);
            Console.WriteLine($"Duration: {_duration} seconds");
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!");
            Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            int totalMilliseconds = seconds * 1000;
            int interval = 250; 
            int cycles = totalMilliseconds / interval;
            for (int i = 0; i < cycles; i++)
            {
                Console.Write("|");
                Thread.Sleep(interval);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }

        protected void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }
}
