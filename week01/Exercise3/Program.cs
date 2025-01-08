using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        
        do
        {
            // Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess;
            int attempts = 0;

            Console.WriteLine("Welcome to the Guess My Number game.");
            
            do
            {
                Console.Write("What is your guess? (From 1 to 100): ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it right, It took you {attempts} attempts.");
                ee

            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine().ToLower();
        } while (playAgain == "yes");
        
        Console.WriteLine("Thanks for playing");
    }
}
