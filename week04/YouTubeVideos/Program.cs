using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("Understand Code", "Code Wizard", 230),
            new Video("How to do the YouTube assignment", "Andrew Hilton", 500),
            new Video("How to make cake", "Chef Albert", 650)
        };

        videos[0].AddComment(new Comment("sam", "Great Job!"));
        videos[0].AddComment(new Comment("Bob", "I love your Videoss!"));
        videos[0].AddComment(new Comment("Andrew", "I can understand code now!"));


        videos[1].AddComment(new Comment("Chase", "Thanks for the tips!"));
        videos[1].AddComment(new Comment("dawson", "Nice Video!"));
        videos[1].AddComment(new Comment("Mindy", "helped me a ton!"));

        videos[2].AddComment(new Comment("Eliza", "Delicius cake!"));
        videos[2].AddComment(new Comment("Martha", "I love cake!"));
        videos[2].AddComment(new Comment("Jeremy", "This helped me a lot!"));

        foreach (var video in videos)
        {
            video.DisplayDetails();
        }
    }
}
