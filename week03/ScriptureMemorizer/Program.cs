using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference();
        reference1._book = "John";
        reference1._chapter = 3;
        reference1._verse = 16;
        reference1._endVerse = 17;
        Scripture scripture1 = new Scripture();
        scripture1._reference = reference1;
        scripture1._originalText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        List<Word> words = scripture1.ConvertVerse(scripture1._originalText);
        string choice = "";
        Console.WriteLine();
        reference1.DisplayText();
        
        
        foreach (Word word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
        while(choice != "quit" && scripture1.IsCompletelyHidden() != true)
            {

            Console.WriteLine("How many words do you want to hide? ");
            int numToHide = int.Parse(Console.ReadLine());

            scripture1.HideRandomWords(numToHide, words);

            Console.Clear();
            reference1.DisplayText();
            
            foreach (Word word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine($"\nPress enter to continue or type 'quit' to finish. ");
            choice = Console.ReadLine();
            }
        Console.WriteLine("Great Job!");
    }
}