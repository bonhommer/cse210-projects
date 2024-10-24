using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video();
        video1._title = "How to get curly hair in 10 minutes";
        video1._author = "Antoine Bonhommer";
        video1._length = 10;
        video1.AddComment(new Comment("Jaqueline", "Nice tuto. Thank you for those advices"));
        video1.AddComment(new Comment("Jayline", "Great video"));
        video1.AddComment(new Comment("Ronaldo", "I finally find a video that explain it step by step"));

        Video video2 = new Video();
        video2._title = "Guitar tutorial for beginner";
        video2._author = "Bill Gates";
        video2._length = 20;
        video2.AddComment(new Comment("Bob", "Thanks for those good explanations"));
        video2.AddComment(new Comment("Denise", "Good presentation"));
        video2.AddComment(new Comment("Wiston", "How long have you been playing guitar?"));

        Video video3 = new Video();
        video3._title = "How to kiss";
        video3._author = "Steves Wulf";
        video3._length = 15;
        video3.AddComment(new Comment("Jessica", "I already knew that"));
        video3.AddComment(new Comment("Lecxi", "Thank you, I want a man to try this"));
        video3.AddComment(new Comment("Vanessa", "Oh my God! That's me in the video"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach(var video in videos)
        {
            Console.WriteLine();
            video.Display();
        }

        
    }
}