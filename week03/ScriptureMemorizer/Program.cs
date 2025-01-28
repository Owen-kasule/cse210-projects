using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.WriteLine("Please choose a scripture to memorize:");
        library.DisplayScriptures();

        int choice = int.Parse(Console.ReadLine());
        Scripture scripture = library.GetScripture(choice);

        Console.WriteLine("Choose a difficulty level (1 = Easy, 2 = Medium, 3 = Hard):");
        int difficulty = int.Parse(Console.ReadLine());
        int wordsToHide = difficulty == 1 ? 1 : difficulty == 2 ? 3 : 5;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'hint' for help. Type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else if (input == "hint")
            {
                Console.WriteLine("Hint: " + scripture.GetHint());
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else
            {
                scripture.HideRandomWords(wordsToHide);
                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You have memorized the scripture:");
                    Console.WriteLine(scripture.GetDisplayText());
                    break;
                }
            }
        }
    }
}
