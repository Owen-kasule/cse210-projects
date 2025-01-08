using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);
        
        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the "+" or "-" sign for applicable grades
        int lastDigit = gradePercentage % 10;

        if (letter != "F") // No "+" or "-" for F grades
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }

            // Special case: No A+ grade, only A and A-
            if (letter == "A" && sign == "+")
            {
                sign = "";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine pass/fail
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You'll do better next time.");
        }
    }
}
