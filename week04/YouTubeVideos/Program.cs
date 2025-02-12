using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create videos with Ugandan authors
        Video video1 = new Video("How to Code in C#", "Owen Kasule Muhereza", 600);
        Video video2 = new Video("Understanding OOP Principles", "Nalwanga Miriam", 850);
        Video video3 = new Video("Building a Website with HTML & CSS", "Mugisha David", 720);
        Video video4 = new Video("Mastering Data Structures", "Nabirye Sarah", 1100);

        // Add comments to each video
        video1.AddComment(new Comment("Katumba Brian", "This tutorial was really helpful!"));
        video1.AddComment(new Comment("Nansubuga Joan", "I love the way you explain things."));
        video1.AddComment(new Comment("Muwanga Peter", "Can you make a video about advanced C# topics?"));

        video2.AddComment(new Comment("Kaggwa John", "Great breakdown of OOP concepts."));
        video2.AddComment(new Comment("Nabukeera Ritah", "This helped me pass my programming exam!"));
        video2.AddComment(new Comment("Lubega Samuel", "Can you explain SOLID principles next?"));

        video3.AddComment(new Comment("Nakitto Diana", "Finally, a clear explanation of HTML and CSS."));
        video3.AddComment(new Comment("Kibuuka Robert", "Please do a tutorial on responsive design."));
        video3.AddComment(new Comment("Semwogerere Paul", "Your teaching style is amazing!"));

        video4.AddComment(new Comment("Namukwaya Fiona", "I struggled with data structures before this."));
        video4.AddComment(new Comment("Sekandi Henry", "More videos on algorithms, please!"));
        video4.AddComment(new Comment("Mukasa Fred", "I wish I had found this video earlier."));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display all videos and their comments
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}
