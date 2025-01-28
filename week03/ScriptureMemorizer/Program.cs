using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Choose a scripture to memorize:");

        // List of scriptures
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("D&C", 89, 18, 21), "And all saints who remember to keep and do these sayings, walking in obedience to the commandments, shall receive health in their navel and marrow to their bones; And shall find wisdom and great treasures of knowledge, even hidden treasures.")
        };

        // Display scripture choices
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetReference()}");
        }

        // User selects scripture
        int choice;
        while (true)
        {
            Console.Write("\nEnter the number of the scripture you want to memorize: ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= scriptures.Count)
            {
                break;
            }
            Console.WriteLine("Invalid choice. Please enter a valid number.");
        }

        // Start memorization process
        Scripture selectedScripture = scriptures[choice - 1];
        StartMemorization(selectedScripture);
    }

    static void StartMemorization(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine("Press ENTER to hide words, or type 'quit' to exit.");
        
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("\nPress ENTER to continue or type 'quit' to exit: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("\nThank you for using the Scripture Memorizer! Goodbye.");
                return;
            }

            scripture.HideRandomWords(2); // Hide 2 words at a time
        }

        Console.Clear();
        Console.WriteLine("Congratulations! You have fully memorized the scripture.");
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
