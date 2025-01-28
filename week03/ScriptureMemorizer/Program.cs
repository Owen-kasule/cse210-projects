using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the scripture reference and text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        // Create the Scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main program loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }
        }
    }
}
