using System;


//For the above and beyond I added the option to enter the number of words that the user would like to exclude. If an option is not chosen then it will default to 3. 
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
        

        scripture1.DisplayText(words);
        Console.WriteLine();
        while(choice != "quit" && scripture1.IsCompletelyHidden() != true)
            {

            Console.WriteLine("How many words do you want to hide? ");
            string response = Console.ReadLine();
            int numToHide = string.IsNullOrWhiteSpace(response) ? 3 : int.Parse(response);

            scripture1.HideRandomWords(numToHide = 3, words);

            Console.Clear();
            reference1.DisplayText();
            
            scripture1.DisplayText(words);
            Console.WriteLine($"\nPress enter to continue or type 'quit' to finish. ");
            choice = Console.ReadLine();
            }
        Console.WriteLine("Great Job!");
    }
}