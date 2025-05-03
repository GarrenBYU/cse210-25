using System;

class Program
{
       enum MenuItem
    {
        Write = 1,
        Display = 2,
        Load = 3,
        Save = 4,
        Quit = 5
    }
    static void Main(string[] args)
    {
        var newJournal = new Journal();
        var newEntry = new Entry();
        // newJournal._entries;

        Console.WriteLine("Welcome to the Journal Program!");
        var choice = MenuItem.Save;
        while(choice != MenuItem.Quit){
            Console.WriteLine("Hello {0} how are you?", "Garren");
            Console.WriteLine($"");

            Console.Write("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit \nWhat would you like to do? ");
            choice = (MenuItem) int.Parse(Console.ReadLine());
            var fileName = "";
            var passChoice = "";
            var pass = "";
            switch (choice)
            {
                case MenuItem.Write:
                    WriteMenuCode(newEntry, newJournal);
                    break;
                case MenuItem.Display:
                    newJournal.DisplayAll();
                    Console.Write("Please hit enter when you are done.");
                    Console.ReadLine();
                    break;
                case MenuItem.Load:
                    Console.Write("What is the file name? ");
                    fileName = Console.ReadLine();
                    //newJournal.RecievePassword(fileName);
                    newJournal.LoadFromFile(fileName);
                    break;
                case MenuItem.Save:
                    Console.Write("What is the file name? ");
                    fileName = Console.ReadLine();
                    Console.Write("Do you want a password? ");
                    passChoice = Console.ReadLine();
                    if(passChoice == "Yes" || passChoice == "yes"){
                        Console.Write("What is the password? ");
                        pass = Console.ReadLine();
                    }
                    newJournal.SaveToFile(fileName, pass);
                    break;
                case MenuItem.Quit:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private static void WriteMenuCode(Entry newEntry, Journal newJournal)
    {
        var newPrompt = new Prompt();
        newPrompt._prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        var theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        newEntry._question = newPrompt.GetRandomPrompt();
        Console.Write($"{newEntry._question} \n >");
        newEntry._answer = Console.ReadLine();
        //string entry = $"Date: {newEntry._date} - Prompt: {newEntry._question} \n{newEntry._answer}";
        newJournal.AddEntry($"Date: {newEntry._date} - Prompt: {newEntry._question} \n{newEntry._answer}");
    }
}
