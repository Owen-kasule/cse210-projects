using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.SetDuration(30); // Example duration
                breathing.Run();
            }
            else if (choice == "2")
            {
                ListingActivity listing = new ListingActivity();
                listing.SetDuration(30); // Example duration
                listing.Run();
            }
            else if (choice == "3")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.SetDuration(30); // Example duration
                reflecting.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
