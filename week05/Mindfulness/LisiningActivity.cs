using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessActivities
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private int _itemCount; 

        public ListingActivity(int duration)
            : base("Listing", "This activity will prompt you to list as many responses as you can on a given topic.", duration)
        {
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are your personal strengths?",
                "When have you felt the holy ghost this month?."
            };
            _itemCount = 0;
        }

        public void Run()
        {
            DisplayStartingMessage();
            string prompt = GetRandomPrompt();
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.WriteLine("You may begin in:");
            ShowCountDown(5);

            DateTime startTime = DateTime.Now;
            List<string> responses = new List<string>();
            while ((DateTime.Now - startTime).TotalSeconds < _duration)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(response))
                {
                    responses.Add(response);
                }
            }
            _itemCount = responses.Count;

            Console.WriteLine($"You listed {_itemCount} items!");
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
