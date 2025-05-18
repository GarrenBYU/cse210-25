using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference1 = new Reference();
        reference1._book = "John";
        reference1._chapter = 3;
        reference1._verse = 16;
        reference1._endVerse = 17;
        Scripture scripture1 = new Scripture();
        scripture1._reference = reference1;
        scripture1._originalText = "16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. 17 For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        List<Word> words = scripture1.ConvertVerse(scripture1._originalText);
        
        foreach (Word word in words)
        {
            Console.Write(word + " ");
        }
    }
}