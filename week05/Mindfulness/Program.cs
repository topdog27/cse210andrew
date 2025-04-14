using System;

namespace MindfulnessActivities
{
    class Program
    {
        static void Main()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Activities Program");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflecting Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                int duration = 0;
                if (choice != "4")
                {
                    Console.Write("Enter the duration for the activity (in seconds): ");
                    if (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
                    {
                        Console.WriteLine("Invalid duration entered. Using default of 30 seconds.");
                        duration = 30;
                    }
                }

                switch (choice)
                {
                    case "1":
                        {
                            BreathingActivity breathing = new BreathingActivity(duration);
                            breathing.Run();
                            break;
                        }
                    case "2":
                        {
                            ReflectingActivity reflecting = new ReflectingActivity(duration);
                            reflecting.Run();
                            break;
                        }
                    case "3":
                        {
                            ListingActivity listing = new ListingActivity(duration);
                            listing.Run();
                            break;
                        }
                    case "4":
                        {
                            running = false;
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
