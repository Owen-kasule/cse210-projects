using System;

/// <summary>
/// The main program class for managing the journal application.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(date, prompt, response);
                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added successfully.");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nDisplaying all journal entries:");
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save (e.g., journal.txt): ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("Journal saved successfully.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load (e.g., journal.txt): ");
                string fileName = Console.ReadLine();
                try
                {
                    journal.LoadFromFile(fileName);
                    Console.WriteLine("\nJournal loaded successfully.");
                    Console.WriteLine("\nDisplaying loaded journal entries:");
                    journal.DisplayAll(); // Automatically display entries after loading
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading journal: {ex.Message}");
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}
