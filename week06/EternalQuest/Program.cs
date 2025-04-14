using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class Program
    {
        static List<Goal> goals = new List<Goal>();
        static int totalScore = 0;

        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Create New Goal");
                Console.WriteLine(" 2. List Goals");
                Console.WriteLine(" 3. Save Goals");
                Console.WriteLine(" 4. Load Goals");
                Console.WriteLine(" 5. Record Event");
                Console.WriteLine(" 6. Display Score");
                Console.WriteLine(" 7. Quit");
                Console.Write("Select a choice from the menu: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateNewGoal();
                        break;
                    case "2":
                        ListGoals();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        DisplayScore();
                        break;
                    case "7":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CreateNewGoal()
        {
            Console.Clear();
            Console.WriteLine("Select the type of goal to create:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.Write("Your choice: ");
            string input = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points for the goal: ");
            int points = int.Parse(Console.ReadLine());

            switch (input)
            {
                case "1":
                    goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("Enter the number of times this goal must be accomplished: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points on completion: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid selection. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

        static void ListGoals()
        {
            Console.Clear();
            Console.WriteLine("Current Goals:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void SaveGoals()
        {
            Console.Clear();
            Console.Write("Enter filename to save goals: ");
            string filename = Console.ReadLine();

            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.WriteLine(totalScore);
                    foreach (Goal goal in goals)
                    {
                        writer.WriteLine(goal.GetSaveData());
                    }
                }
                Console.WriteLine("Goals saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving goals: " + ex.Message);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void LoadGoals()
        {
            Console.Clear();
            Console.Write("Enter filename to load goals: ");
            string filename = Console.ReadLine();

            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string scoreLine = reader.ReadLine();
                    totalScore = int.Parse(scoreLine);
                    goals.Clear();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(';');
                        string goalType = parts[0];

                        if (goalType == "SimpleGoal")
                        {
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            bool isComplete = bool.Parse(parts[4]);

                            SimpleGoal sg = new SimpleGoal(name, description, points);
                            sg.SetCompletion(isComplete);
                            goals.Add(sg);
                        }
                        else if (goalType == "EternalGoal")
                        {
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            goals.Add(new EternalGoal(name, description, points));
                        }
                        else if (goalType == "ChecklistGoal")
                        {
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);
                            int targetCount = int.Parse(parts[4]);
                            int bonusPoints = int.Parse(parts[5]);
                            int currentCount = int.Parse(parts[6]);
                            bool isComplete = bool.Parse(parts[7]);

                            ChecklistGoal cg = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                            cg.SetCurrentCount(currentCount, isComplete);
                            goals.Add(cg);
                        }
                    }
                }
                Console.WriteLine("Goals loaded successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading goals: " + ex.Message);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void RecordEvent()
        {
            Console.Clear();
            Console.WriteLine("Select a goal to record an event:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
            }
            Console.Write("Your choice: ");
            int index = int.Parse(Console.ReadLine()) - 1;
            if (index >= 0 && index < goals.Count)
            {
                int pointsEarned = goals[index].RecordEvent();
                totalScore += pointsEarned;
                Console.WriteLine($"Event recorded! You earned {pointsEarned} points.");
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void DisplayScore()
        {
            Console.Clear();
            Console.WriteLine($"Your total score is: {totalScore}");
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}
