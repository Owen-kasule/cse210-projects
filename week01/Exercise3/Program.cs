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

            Console.WriteLine("\n🎉 Welcome to the 'Guess My Number' game 🎉");
            Console.WriteLine("I have chosen a magic number between 1 and 100.");
            Console.WriteLine("Can you guess what it is? Let's find out\n");

            do
            {
                Console.Write("🔍 Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("📈 Too low, Try guessing a higher number.");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("📉 Too high, Try guessing a lower number.");
                }
                else
                {
                    Console.WriteLine($"\n🎊 Congratulations. You guessed the magic number in {attempts} attempts 🎊");
                }
            } while (guess != magicNumber);

            Console.Write("\nWould you like to play again? Type 'yes' to play again or 'no' to quit: ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("\nThank you for playing 'Guess My Number' Have a great day 😊");
    }
}