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
        collection1.Display();
    }
}