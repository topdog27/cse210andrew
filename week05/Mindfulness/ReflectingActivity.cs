using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessActivities
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectingActivity(int duration)
            : base("Reflecting", "This activity will help you reflect on times of strength and resilience, consider the following prompt:", duration)
        {
            _prompts = new List<string>
            {
                "Think of a time when you overcame a difficult challenge.",
                "Recall a moment when you felt truly grateful.",
                "Think of a time when you helped someone in need."
            };

            _questions = new List<string>
            {
                "Why was this experience meaningful to you?",
                "How did this experience change you?",
                "What did you learn about yourself from this experience?",
                "How can you use this experience to overcome future challenges?"
            };
        }

        public void Run()
        {
            DisplayStartingMessage();

            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on the following questions as they relate to this experience:");
            ShowSpinner(3);

            DateTime startTime = DateTime.Now;
            int questionIndex = 0;
            while ((DateTime.Now - startTime).TotalSeconds < _duration)
            {
                string question = _questions[questionIndex % _questions.Count];
                Console.WriteLine($"> {question}");
                ShowSpinner(5);
                questionIndex++;
            }

            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            Random rand = new Random();
            int index = rand.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}
