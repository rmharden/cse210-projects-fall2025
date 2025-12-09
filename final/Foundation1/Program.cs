/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
December 9, 2025

Final Project
Program 1: Abstraction with YouTube Videos
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Console.Clear();
        Console.WriteLine("Welcome to Foundation 1: Abtraction with YouTube Videos!");


        // First Video
        Video v1 = new Video("How to Oil Paint: A beginner's guide", "Paul Hall", 1020);

        Comment c1v1 = new Comment("Wilhelmina Isa Wright", "This is fantastic! I didn't know we should put gesso on the canvas first.");
        v1.AddComment(c1v1);

        Comment c2v1 = new Comment("Lapreal Heaton", "Wonderful! I'm looking forward to the next video.");
        v1.AddComment(c2v1);

        Comment c3v1 = new Comment("Rasmus Frandsen", "Exciting! The details on brush selections were exactly what I was looking for!");
        v1.AddComment(c3v1);

        _videos.Add(v1);


        // Second Video
        Video v2 = new Video("Oil Painting: Mixing Colors", "Niels Sørensen", 1800);

        Comment c1v2 = new Comment("Annice McArthur", "This is great! Thanks for sharing a new way to look at complementary colors!");
        v2.AddComment(c1v2);

        Comment c2v2 = new Comment("Laura Belle", "What? I never knew this is how you brighten colors without white!");
        v2.AddComment(c2v2);

        Comment c3v2 = new Comment("Erastus Jørgensen", "Splendid!");
        v2.AddComment(c3v2);

        Comment c4v2 = new Comment("Wayne Wilder", "Amazing! I'm looking forward to trying this technique.");
        v2.AddComment(c4v2);

        _videos.Add(v2);


        // Third Video


        Video v3 = new Video("Painting Techniques", "Sidse Thøgersdatter", 720);

        Comment c1v3 = new Comment("Hugh Falconer", "It didn't occur to me to use a flat brush for that technique. Awesome!");
        v3.AddComment(c1v3);

        Comment c2v3 = new Comment("Sam Stone", "Using the filbert brush to paint clouds was new to me. Thanks for showing us!");
        v3.AddComment(c2v3);

        Comment c3v3 = new Comment("Anna Höpler", "Lovely! What fun.");
        v3.AddComment(c3v3);

        Comment c4v3 = new Comment("Jodocus Wiesmann", "Wow! I'm inspired!");
        v3.AddComment(c4v3);

        _videos.Add(v3);


        // v1.DisplayVideos();
        // v2.DisplayVideos();
        // v3.DisplayVideos();

        foreach (Video video in _videos)
        {
            video.Display();
        }
    }
}

/*
Sites I used for help:

BYU-Idaho Video by Chad Macbeth
https://video.byui.edu/media/t/1_fnsp1qsi/259941952
https://video.byui.edu/media/t/1_fnsp1qsi
*/