using System;

class Program
{
    static void Main()
    {
        // Step 5 Fix: Ensures `scriptures.txt` is loaded properly
        ScriptureCollection library = new ScriptureCollection("scriptures.txt");
        MemorizationScripture scripture = library.GetRandomScripture();

        if (scripture == null) // Handles missing scriptures correctly
        {
            Console.WriteLine("No scriptures available. Please check your file.");
            return; // Stops execution before errors occur
        }

        Console.Clear();
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit") break;

            scripture.HideWords(2);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nAll words hidden. Program ending.");
                break;
            }
        }
    }
}
