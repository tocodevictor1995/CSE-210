using System;
using System.Collections.Generic;




class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "John", 300);
        video1.AddComment(new Comment("Alice", "Great video, very helpful!"));
        video1.AddComment(new Comment("Bob", "Thanks for sharing this!"));
        video1.AddComment(new Comment("Charlie", "Could you cover more advanced topics?"));

        Video video2 = new Video("Python Basics", "Emily", 240);
        video2.AddComment(new Comment("David", "Nice explanation!"));
        video2.AddComment(new Comment("Emma", "I learned a lot from this video."));

        Video video3 = new Video("Java Programming", "Michael", 400);
        video3.AddComment(new Comment("Grace", "Good job!"));
        video3.AddComment(new Comment("Henry", "I have a question about inheritance."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
