using System;

class Program
{
    static void Main(string[] args)
    {
        // Scripture reference and text
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer Program");
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.\n");

        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are now hidden. Well done");
                break;
            }

            Console.Clear();
        }

        Console.WriteLine("Thank you for using the Scripture Memorizer Program");
    }
}
