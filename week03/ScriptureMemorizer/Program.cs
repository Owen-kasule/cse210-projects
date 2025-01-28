using System;

class Program
{
    static void Main(string[] args)
    {
        // Multiple scripture options for creativity
        var scriptures = new[]
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Psalm", 23, 1, 4), "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters. He restoreth my soul: he leadeth me in the paths of righteousness for his name's sake. Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me.")
        };

        // Select a random scripture to start
        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Length)];

        // Main program loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("\nThank you for using the Scripture Memorizer. Goodbye!");
                break;
            }

            selectedScripture.HideRandomWords(3);

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(selectedScripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Well done");
                break;
            }
        }

        // Close program gracefully
        Console.WriteLine("\nPress any key to close the program...");
        Console.ReadKey();
    }
}
