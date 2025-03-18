using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        // Initialize necessary objects
        TerminalServices menu = new TerminalServices();
        Journal journal = new Journal();
        File newFile = new File();
        
        Console.WriteLine("Welcome to the Journal Program!");
        int choice;

        do
        {
            // Display the menu and capture user choice
            menu.displayMenu();
            Console.Write($"Please select an optiion (1-5):");
            choice = int.Parse(Console.ReadLine());

             if (choice == 1)
            {
               // Create a new journal entry
               Entry entry = new Entry();
               menu.prompt(); // Display a random question prompt
                    string answer = Console.ReadLine(); // Capture user response
                    string question = menu._question;

                    entry.SetEntry(answer, question); // Set entry details
                    journal._journal.Add(entry); // Add the entry to the journal             
               }
            
            else if (choice == 2)
            {
                // Display all journal entries
                journal.DisplayJournal();
            }
            else if (choice == 3)
            {
                // Load journal entries from a file
                string file = newFile._fileName;
                List<Entry> savedEntries =  newFile.ReadFile();
                foreach (Entry entry in savedEntries)
                {
                    journal._journal.Add(entry); // Add entries to the journal
                }
            }
            else if (choice == 4)
            {
                // Save journal entries to a file
                newFile.WriteFile(journal._journal);
                string file = newFile._fileName;
            }
            else
            {
                Console.WriteLine("See you next time!");
            }

        } while (choice < 5); // Continue loop until the user chooses to quit
    }
}