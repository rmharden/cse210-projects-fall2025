using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Console.WriteLine("Welcome to Foundation 1: Abtraction with YouTube Videos!");

        Video v1 = new Video("How to Oil Paint: A beginner's guide", "Paul Hall", 1020);

        Comment c1v1 = new Comment("Wilhelmina Isa Wright", "This is fantastic! I didn't know we should put gesso on the canvas first.");
        v1.AddCommentToList(c1v1);
        Comment c2v1 = new Comment("Lapreal Heaton", "Wonderful! I'm looking forward to the next video.");
        v1.AddCommentToList(c2v1);
        Comment c3v1 = new Comment("Rasmus Frandsen", "Exciting! The details on brush selections were exactly what I was looking for!");


        Video v2 = new Video("Oil Painting: Mixing Colors", "Niels Sørensen", 1800);

        Comment c1v2 = new Comment("Annice McArthur", "This is great! Thanks for sharing a new way to look at complementary colors!");
        v2.AddCommentToList(c1v2);
        Comment c2v2 = new Comment("Laura Belle", "What? I never knew this is how you brighten colors without white!");
        v2.AddCommentToList(c2v2);
        Comment c3v2 = new Comment("Erastus Jørgensen", "Splendid!");
        v2.AddCommentToList(c3v2);
        Comment c4v2 = new Comment("Wayne Wilder", "Amazing! I'm looking forward to trying this technique.");
        v2.AddCommentToList(c4v2);

        Video v3 = new Video(" :  ", " ", 0);

        Comment c1v3 = new Comment(" ", "");
        v3.AddCommentToList(c1v3);
        Comment c2v3 = new Comment("", "");
        v3.AddCommentToList(c2v3);
        Comment c3v3 = new Comment("", "");
        v3.AddCommentToList(c3v3);
        Comment c4v3 = new Comment(" ", "! ");
        v3.AddCommentToList(c4v3);
    }
}

/*
Sites I used for help:

BYU-Idaho Video by Chad Macbeth
https://video.byui.edu/media/t/1_fnsp1qsi/259941952
https://video.byui.edu/media/t/1_fnsp1qsi

*/