using System;

class Program
{
    static void Main(string[] args)
    {
        Collection collection1 = new Collection();
        Video video1 = new Video("How to make Banana Bread", "Garren M", 1480);
        Comment comment1 = new Comment("Moash", "I freaking love banana bread!");
        Comment comment2 = new Comment("Jasnah", "Woah! Nice recipe!");
        Comment comment3 = new Comment("Lift", "Eh I have seen better.");
        Comment comment4 = new Comment("Rock", "You know what is better? STEW!");

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);
        video1._comments.Add(comment4);
        collection1._videos.Add(video1);


        Video video2 = new Video("How to Survive the Apocolypse", "Kaladin", 7690);
        Comment comment5 = new Comment("Shallan", "I think he needed better boots.");
        Comment comment6 = new Comment("Dalinar", "Well taught with honor.");
        Comment comment7 = new Comment("Adolin", "Bridge boy is good with a weapon.");
        Comment comment8 = new Comment("Taravangian", "This was exceedingly dumb.");

        video2._comments.Add(comment5);
        video2._comments.Add(comment6);
        video2._comments.Add(comment7);
        video2._comments.Add(comment8);
        collection1._videos.Add(video2);


        Video video3 = new Video("How to Study", "Jasnah", 77777);
        Comment comment9 = new Comment("Navani", "Good input with solid study ethics behind it.");
        Comment comment10 = new Comment("Teft", "I think I understood every 15th word. Are you even talking in my own language?");
        Comment comment11 = new Comment("Amaram", "Such a good presentation fit for a Bride.");
        Comment comment12 = new Comment("Lopen", "The Lopen thinks this was a good presentation, but had too many arms. There are a ton of good jokes about a one armed Herdazian.");

        video3._comments.Add(comment9);
        video3._comments.Add(comment10);
        video3._comments.Add(comment11);
        video3._comments.Add(comment12);
        collection1._videos.Add(video3);


        collection1.Display();
    }
}