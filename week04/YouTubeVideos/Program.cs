using System;

public class Program
{
    public static void Main()
    {
        // Create videos
        Video video1 = new Video("Learning C#", "John Doe", 600);
        Video video2 = new Video("Understanding OOP", "Jane Smith", 1200);

        // Add comments
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));

        video2.AddComment(new Comment("Charlie", "Loved the examples."));
        video2.AddComment(new Comment("Dave", "Could you add more details?"));

        // Display video details
        video1.DisplayVideoDetails();
        video2.DisplayVideoDetails();
    }
}
